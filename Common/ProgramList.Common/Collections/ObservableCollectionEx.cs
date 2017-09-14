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
        private bool _NotificationsSuspended = false;

        public void SuspendNotifications()
        {
            _NotificationsSuspended = true;
        }

        public void ResumeNotifications()
        {
            _NotificationsSuspended = false;
            if (_notificationsWaiting)
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                _notificationsWaiting = false;
            }
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (_NotificationsSuspended)
            {
                _notificationsWaiting = true;
                return;
            }
            base.OnCollectionChanged(e);
        }
    }
}
