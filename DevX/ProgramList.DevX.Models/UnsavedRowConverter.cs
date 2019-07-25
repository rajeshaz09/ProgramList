using ProgramList.DevX.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ProgramList.DevX.Models
{
    public class UnsavedRowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selectionState = (SelectionState)value;
            return selectionState.HasFlag(SelectionState.Unsaved);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
