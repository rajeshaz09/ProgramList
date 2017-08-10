using ProgramList.TelerikPOC.Converters;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace ProgramList.TelerikPOC.Columns
{
    public static class ColumnExtensions
    {
        private static Style DefaultCellStyle;
        private static IValueConverter RGBToBrushConverter;
        static ColumnExtensions()
        {
            DefaultCellStyle = Application.Current.FindResource("GridViewCellCoreValidationStyle") as Style;
            RGBToBrushConverter = new RGBToBrushConverter();

        }
        public static void ApplyDefaultSettings(this GridViewBoundColumnBase column, 
            string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            column.UniqueName = header;

            column.Header = header;
            column.DataType = dataType;
            column.IsVisible = isVisible;
            column.IsReadOnly = isReadOnly;
            column.IsEnabled = isEnabled;
            column.IsSelected = isSelected;
            column.IsGroupable = true;

            column.IsReadOnlyBinding = new Binding($"IsReadOnly_{column.UniqueName}") { Mode = BindingMode.TwoWay };



            var cellStyle = new Style(typeof(GridViewCell), DefaultCellStyle);
            cellStyle.Setters.Add(new Setter(Control.ForegroundProperty, new Binding($"Foreground_{column.UniqueName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(Control.BackgroundProperty, new Binding($"Background_{column.UniqueName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"IsEnabled_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            cellStyle.Setters.Add(new Setter(GridViewCell.IsInEditModeProperty, new Binding($"IsInEditMode_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            cellStyle.Setters.Add(new Setter(GridViewCell.IsCurrentProperty, new Binding($"IsCurrent_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            column.CellStyle = cellStyle;
        }
    }
}
