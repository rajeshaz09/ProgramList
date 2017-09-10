using Infragistics.Windows.DataPresenter;
using ProgramList.Common.Converters;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ProgramList.InfragisticsPOC.Columns
{
    public static class ColumnExtensions
    {
        //private static Style DefaultCellStyle = Application.Current.FindResource("GridViewCellCoreValidationStyle") as Style;
        private static IValueConverter RGBToBrushConverter = new RGBToBrushConverter();
        public static void ApplyDefaultSettings(this Field column, 
            string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            column.Name = header;

            column.Label = header;
            column.DataType = dataType;
            column.Visibility= isVisible? Visibility.Visible: Visibility.Collapsed;
            column.IsReadOnly = isReadOnly;
            column.IsEnabled = isEnabled;
            column.IsSelected = isSelected;
            column.AllowGroupBy = true;


            //column.Rea = new Binding($"IsReadOnly_{column.FieldName}") { Mode = BindingMode.TwoWay };



            var cellStyle = new Style(typeof(CellValuePresenter));
            cellStyle.Setters.Add(new Setter(Control.ForegroundProperty, new Binding($"DataItem.Foreground_{column.Name}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(Control.BackgroundProperty, new Binding($"DataItem.Background_{column.Name}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"DataItem.IsEnabled_{column.Name}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridCell.IsInEditModeProperty, new Binding($"IsInEditMode_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridViewCell.IsCurrentProperty, new Binding($"IsCurrent_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            column.CellValuePresenterStyle = cellStyle;
            


        }
    }
}
