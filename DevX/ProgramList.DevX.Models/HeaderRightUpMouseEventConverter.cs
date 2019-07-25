using DevExpress.Mvvm.UI;
using System.Windows.Input;

namespace ProgramList.DevX.Models
{
    public class HeaderRightUpMouseEventConverter : EventArgsConverterBase<MouseEventArgs>
    {
        protected override object Convert(object sender, MouseEventArgs args)
        {
            return args;
        }
    }
}
