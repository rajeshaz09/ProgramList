using System;
using System.Globalization;
using System.Windows.Data;

namespace ProgramList.DevX.Models
{
    public class BooleanToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string serverBooleanValue = (string)value;
            if (string.IsNullOrEmpty(serverBooleanValue))
                return null;
            return (serverBooleanValue == "Y") ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            return (bool)value == true ? "Y" : "N";
        }
    }
}
