using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.DevX.Models
{
    public class MyCollection<T> : MyObservableCollectionEx<T>, IMyCollection<T>
    {
        //public void ResumeNotifications()
        //{
        //}

        //public void SuspendNotifications()
        //{
        //}
    }


    public interface IMyCollection<T>:IList<T>, ISuspendNotifications
    {
    }

    public interface ISuspendNotifications
    {
        void ResumeNotifications();
        void SuspendNotifications();
    }
}
