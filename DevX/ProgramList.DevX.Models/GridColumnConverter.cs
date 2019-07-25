using DevExpress.Xpf.Grid;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ProgramList.DevX.Models
{
    public class GridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is GridColumn)
            {
                return (value as GridColumn)?.DataContext;
            }
            return null;
        }
    }
}
