using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Threading;

namespace ProgramList.DevX.Models
{
    /// <summary>
    /// RadObservableCollection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class MyObservableCollectionEx<T> : ObservableCollection<T>, ISuspendNotifications, INotifyCollectionStateProvider
    {

        private bool _lockNotify;

        public MyObservableCollectionEx() : base() { }

        public MyObservableCollectionEx(IEnumerable<T> collection) : base(collection) { }

        public MyObservableCollectionEx(List<T> list) : base(list) { }

        [field: NonSerialized()]
        public override event NotifyCollectionChangedEventHandler CollectionChanged;
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {

            if (_lockNotify)
                return;

            var eh = CollectionChanged;
            if (eh != null)
            {
                Dispatcher dispatcher = (from NotifyCollectionChangedEventHandler nh in eh.GetInvocationList()
                                         let dpo = nh.Target as DispatcherObject
                                         where dpo != null
                                         select dpo.Dispatcher).FirstOrDefault();

                if (dispatcher != null && dispatcher.CheckAccess() == false)
                {
                    dispatcher.Invoke(DispatcherPriority.DataBind, (Action)(() => OnCollectionChanged(e)));
                }
                else
                {
                    foreach (NotifyCollectionChangedEventHandler nh in eh.GetInvocationList())
                        nh.Invoke(this, e);
                }
            }
        }

        #region INotifyPropertyChanged

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (!_lockNotify)
                base.OnPropertyChanged(e);
        }

        #endregion

        public void ResumeNotifications()
        {
            _lockNotify = false;
        }

        public void SuspendNotifications()
        {
            _lockNotify = true;
        }

        public virtual void AddRange(IEnumerable<T> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException("items");
            }

            if (_lockNotify)
                this.SuspendNotifications();

            foreach (T item in items)
            {
                this.Add(item);
            }

            if (!_lockNotify)
                this.ResumeNotifications();
        }
    }
}
