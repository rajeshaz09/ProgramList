﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ProgramList.TelerikPOC.Converters
{
    public class RGBToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString(value?.ToString()));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush)
            {

                return ((SolidColorBrush)value).Color.ToString();
            }
            return null;
        }
    }
}
