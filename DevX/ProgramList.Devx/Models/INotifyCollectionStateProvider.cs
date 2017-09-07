using System.Collections.Specialized;

namespace ProgramList.DevX.Models
{
    internal interface INotifyCollectionStateProvider
    {
        event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
