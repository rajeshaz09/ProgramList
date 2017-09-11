using C1.WPF.FlexGrid;
using ProgramList.Common.Converters;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ProgramList.C1FlexGrid.Columns
{
    public static class ColumnExtensions
    {
        //private static Style DefaultCellStyle = Application.Current.FindResource("GridViewCellCoreValidationStyle") as Style;
        private static IValueConverter RGBToBrushConverter = new RGBToBrushConverter();
        public static void ApplyDefaultSettings(this Column column, 
            string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            column.ColumnName = header;

            column.Header = header;
            column.DataType = dataType;
            column.Visible = isVisible;
            column.IsReadOnly = isReadOnly;
            //column.IsEnabled = isEnabled;
            column.Selected = isSelected;
            //column.GroupAggregate = true;

            column.MinWidth = 95;


            //column.Rea = new Binding($"IsReadOnly_{column.FieldName}") { Mode = BindingMode.TwoWay };



           /* var cellStyle = new CellStyle();
            
            cellStyle.Setters.Add(new Setter(RowCol.ForegroundProperty, new Binding($"Data.Foreground_{column.FieldName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(RowCol.BackgroundProperty, new Binding($"Data.Background_{column.FieldName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"Data.IsEnabled_{column.FieldName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridCell.IsInEditModeProperty, new Binding($"IsInEditMode_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridViewCell.IsCurrentProperty, new Binding($"IsCurrent_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            column.CellStyle = cellStyle;
            */


        }
    }
}
