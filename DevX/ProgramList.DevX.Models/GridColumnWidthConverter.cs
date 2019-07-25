using DevExpress.Xpf.Grid;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ProgramList.DevX.Models
{
    public class GridColumnWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
            {
                return new GridColumnWidth((double)value);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is GridColumnWidth)
            {
                return ((GridColumnWidth)value).Value;
            }
            return double.NaN;
        }
    }
}
