using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.Collections
{
    public class ObservableCollectionEx<T> : ObservableCollection<T>
    {
        private bool _notificationsWaiting = false;
        private bool _suspendNotifications = false;

        public void SuspendNotifications()
        {
            _suspendNotifications = true;
        }

        public void ResumeNotifications()
        {
            _suspendNotifications = false;
            if (_notificationsWaiting)
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                _notificationsWaiting = false;
            }
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (_suspendNotifications)
            {
                _notificationsWaiting = true;
                return;
            }
            base.OnCollectionChanged(e);
        }
    }
}
