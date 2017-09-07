using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.DevX.Models
{

    [Serializable]
    public class ObservableCollectionEx<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged,
                                             IDisposable
    {
        #region Constants

        private const string _countString = "Count";

        // This must agree with Binding.IndexerName.  It is declared separately 
        // here so as to avoid a dependency on PresentationFramework.dll. 
        private const string _indexerName = "Item[]";

      
        [field: NonSerialized()]
        private static readonly NotifyCollectionChangedEventHandler _emptyDelegate = delegate { };

        #endregion
        
        #region Private Fields

        [field: NonSerialized()]
        private ReentryMonitor _monitor = new ReentryMonitor();

        
        [field: NonSerialized()]
        private NotificationInfo _notifyInfo;

        
        [field: NonSerialized()]
        private bool _disableReentry;

        [field: NonSerialized()]
        Action FireCountAndIndexerChanged = delegate { };

        [field: NonSerialized()]
        Action FireIndexerChanged = delegate { };

        #endregion Private Fields

       
        #region Protected Fields

        
        [field: NonSerializedAttribute()]
        protected virtual event PropertyChangedEventHandler PropertyChanged;

       
        [field: NonSerialized()]
        protected virtual event NotifyCollectionChangedEventHandler CollectionChanged = _emptyDelegate;

        #endregion Protected Fields

       
        #region Constructors

      
        public ObservableCollectionEx()
            : base()
        {
        }

       
        public ObservableCollectionEx(List<T> list)
            : base((list != null) ? new List<T>(list.Count) : list)
        {
            foreach (T item in list)
            {
                Items.Add(item);
            }
        }

      
        public ObservableCollectionEx(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            using (IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Items.Add(enumerator.Current);
                }
            }
        }

       
        public ObservableCollectionEx(ObservableCollectionEx<T> parent, bool notify)
            : base(parent.Items)
        {
            _notifyInfo = new NotificationInfo();
            _notifyInfo.RootCollection = parent;

            if (notify)
            {
                CollectionChanged = _notifyInfo.Initialize();
            }
        }
        
        ~ObservableCollectionEx()
        {
            Dispose(false);
        }

        #endregion Constructors

     
        #region Public Events

        #region INotifyPropertyChanged implementation

        
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                if (null == _notifyInfo)
                {
                    if (null == PropertyChanged)
                    {
                        FireCountAndIndexerChanged = delegate
                        {
                            OnPropertyChanged(new PropertyChangedEventArgs(_countString));
                            OnPropertyChanged(new PropertyChangedEventArgs(_indexerName));
                        };
                        FireIndexerChanged = delegate
                        {
                            OnPropertyChanged(new PropertyChangedEventArgs(_indexerName));
                        };
                    }

                    PropertyChanged += value;
                }
                else
                    _notifyInfo.RootCollection.PropertyChanged += value;
            }

            remove
            {
                if (null == _notifyInfo)
                {
                    PropertyChanged -= value;

                    if (null == PropertyChanged)
                    {
                        FireCountAndIndexerChanged = delegate { };
                        FireIndexerChanged = delegate { };
                    }
                }
                else
                    _notifyInfo.RootCollection.PropertyChanged -= value;
            }
        }

        #endregion INotifyPropertyChanged implementation

        #region INotifyCollectionChanged implementation
        
        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
        {
            add
            {
                if (null == _notifyInfo)
                {
                    // Remove ballast delegate if necessary
                    if (1 == CollectionChanged.GetInvocationList().Length)
                        CollectionChanged -= _emptyDelegate;

                    CollectionChanged += value;
                    _disableReentry = CollectionChanged.GetInvocationList().Length > 1;
                }
                else
                    _notifyInfo.RootCollection.CollectionChanged += value;
            }

            remove
            {
                if (null == _notifyInfo)
                {
                    CollectionChanged -= value;

                    if ((null == CollectionChanged) || (0 == CollectionChanged.GetInvocationList().Length))
                        CollectionChanged += _emptyDelegate;

                    _disableReentry = CollectionChanged.GetInvocationList().Length > 1;
                }
                else
                    _notifyInfo.RootCollection.CollectionChanged -= value;
            }
        }

        #endregion INotifyCollectionChanged implementation

        #endregion Public Events


        #region Public Methods
        public void Move(int oldIndex, int newIndex)
        {
            MoveItem(oldIndex, newIndex);
        }

        public ObservableCollectionEx<T> DelayNotifications()
        {
            return new ObservableCollectionEx<T>((null == _notifyInfo) ? this : _notifyInfo.RootCollection, true);
        }

       
        public ObservableCollectionEx<T> DisableNotifications()
        {
            return new ObservableCollectionEx<T>((null == _notifyInfo) ? this : _notifyInfo.RootCollection, false);
        }


        #endregion Public Methods

       
        #region Protected Methods

        
        protected override void ClearItems()
        {
            CheckReentrancy();

            base.ClearItems();

            FireCountAndIndexerChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        
        protected override void RemoveItem(int index)
        {
            CheckReentrancy();
            T removedItem = this[index];

            base.RemoveItem(index);

            FireCountAndIndexerChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removedItem, index));
        }

       
        protected override void InsertItem(int index, T item)
        {
            CheckReentrancy();

            base.InsertItem(index, item);

            FireCountAndIndexerChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
        }

        
        protected override void SetItem(int index, T item)
        {
            CheckReentrancy();

            T originalItem = this[index];
            base.SetItem(index, item);

            FireIndexerChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, originalItem, item, index));
        }


        protected virtual void MoveItem(int oldIndex, int newIndex)
        {
            CheckReentrancy();

            T removedItem = this[oldIndex];
            base.RemoveItem(oldIndex);
            base.InsertItem(newIndex, removedItem);

            FireIndexerChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move, removedItem, newIndex, oldIndex));
        }

      
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged(this, e);
        }

        
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            using (BlockReentrancy())
            {
                CollectionChanged(this, e);
            }
        }

        
        protected IDisposable BlockReentrancy()
        {
            return _monitor.Enter();
        }

        
        protected void CheckReentrancy()
        {
            
            if ((_disableReentry) && (_monitor.IsNotifying))
            {
                throw new InvalidOperationException("ObservableCollectionEx Reentrancy Not Allowed");
            }
        }

        #endregion Protected Methods

       
        #region IDisposable

        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
        protected virtual void Dispose(bool reason)
        {
            // Fire delayed notifications
            if (null != _notifyInfo)
            {
                if (_notifyInfo.HasEventArgs)
                {
                    if (null != _notifyInfo.RootCollection.PropertyChanged)
                    {
                        if (_notifyInfo.IsCountChanged)
                            _notifyInfo.RootCollection.OnPropertyChanged(new PropertyChangedEventArgs(_countString));

                        _notifyInfo.RootCollection.OnPropertyChanged(new PropertyChangedEventArgs(_indexerName));
                    }

                    using (_notifyInfo.RootCollection.BlockReentrancy())
                    {
                        NotifyCollectionChangedEventArgs args = _notifyInfo.EventArgs;

                        foreach (Delegate delegateItem in _notifyInfo.RootCollection.CollectionChanged.GetInvocationList())
                        {
                            try
                            {
                                delegateItem.DynamicInvoke(new object[] { _notifyInfo.RootCollection, args });
                            }
                            catch (TargetInvocationException e)
                            {
                                if ((e.InnerException is NotSupportedException) && (delegateItem.Target is ICollectionView))
                                {
                                    (delegateItem.Target as ICollectionView).Refresh();
                                }
                                else
                                    throw;
                            }
                        }
                    }

                    // Reset and reuse if necessary
                    CollectionChanged = _notifyInfo.Initialize();
                }
            }
        }

        #endregion

        #region Private Types


        [Serializable()]

        private class ReentryMonitor : IDisposable
        {
            #region Fields

            int _referenceCount;

            #endregion

            #region Methods

            public IDisposable Enter()
            {
                ++_referenceCount;

                return this;
            }

            public void Dispose()
            {
                --_referenceCount;
            }

            public bool IsNotifying { get { return _referenceCount != 0; } }

            #endregion
        }

        private class NotificationInfo
        {
            #region Fields

            private Nullable<NotifyCollectionChangedAction> _action;

            private IList _newItems;

            private IList _oldItems;

            private int _newIndex;

            private int _oldIndex;

            #endregion

            #region Methods

            public NotifyCollectionChangedEventHandler Initialize()
            {
                _action = null;
                _newItems = null;
                _oldItems = null;

                return (sender, args) =>
                {
                    ObservableCollectionEx<T> wrapper = sender as ObservableCollectionEx<T>;
                    Debug.Assert(null != wrapper, "Calling object must be ObservableCollectionEx<T>");
                    Debug.Assert(null != wrapper._notifyInfo, "Calling object must be Delayed wrapper.");

                    // Setup 
                    _action = args.Action;

                    switch (_action)
                    {
                        case NotifyCollectionChangedAction.Add:
                            _newItems = new List<T>();
                            IsCountChanged = true;
                            wrapper.CollectionChanged = (s, e) =>
                            {
                                AssertActionType(e);
                                foreach (T item in e.NewItems)
                                    _newItems.Add(item);
                            };
                            wrapper.CollectionChanged(sender, args);
                            break;

                        case NotifyCollectionChangedAction.Remove:
                            _oldItems = new List<T>();
                            IsCountChanged = true;
                            wrapper.CollectionChanged = (s, e) =>
                            {
                                AssertActionType(e);
                                foreach (T item in e.OldItems)
                                    _oldItems.Add(item);
                            };
                            wrapper.CollectionChanged(sender, args);
                            break;

                        case NotifyCollectionChangedAction.Replace:
                            _newItems = new List<T>();
                            _oldItems = new List<T>();
                            wrapper.CollectionChanged = (s, e) =>
                            {
                                AssertActionType(e);
                                foreach (T item in e.NewItems)
                                    _newItems.Add(item);

                                foreach (T item in e.OldItems)
                                    _oldItems.Add(item);
                            };
                            wrapper.CollectionChanged(sender, args);
                            break;
                        case NotifyCollectionChangedAction.Move:
                            _newIndex = args.NewStartingIndex;
                            _newItems = args.NewItems;
                            _oldIndex = args.OldStartingIndex;
                            _oldItems = args.OldItems;
                            wrapper.CollectionChanged = (s, e) =>
                            {
                                throw new InvalidOperationException(
                                    "Due to design of NotifyCollectionChangedEventArgs combination of multiple Move operations is not possible");
                            };
                            break;
                        case NotifyCollectionChangedAction.Reset:
                            IsCountChanged = true;
                            wrapper.CollectionChanged = (s, e) => { AssertActionType(e); };
                            break;
                    }
                };
            }

            #endregion

            #region Properties

            public ObservableCollectionEx<T> RootCollection { get; set; }

            public bool IsCountChanged { get; private set; }

            public NotifyCollectionChangedEventArgs EventArgs
            {
                get
                {
                    switch (_action)
                    {
                        case NotifyCollectionChangedAction.Reset:
                            return new NotifyCollectionChangedEventArgs(_action.Value);

                        case NotifyCollectionChangedAction.Add:
                            return new NotifyCollectionChangedEventArgs(_action.Value, _newItems);


                        case NotifyCollectionChangedAction.Remove:

                            return new NotifyCollectionChangedEventArgs(_action.Value, _oldItems);

                        case NotifyCollectionChangedAction.Move:
                            return new NotifyCollectionChangedEventArgs(_action.Value, _oldItems[0], _newIndex, _oldIndex);

                        case NotifyCollectionChangedAction.Replace:
                            return new NotifyCollectionChangedEventArgs(_action.Value, _newItems, _oldItems);

                    }

                    return null;
                }
            }

            public bool HasEventArgs
            {
                get { return _action.HasValue; }
            }

            #endregion

            #region Private Helper Methods

            private void AssertActionType(NotifyCollectionChangedEventArgs e)
            {
                if (e.Action != _action)
                {
                    throw new InvalidOperationException(
                        string.Format("Attempting to perform {0} during {1}. Mixed actions on the same delayed interface are not allowed.",
                        e.Action, _action));
                }
            }

            #endregion
        }

        #endregion Private Types
    }
}
