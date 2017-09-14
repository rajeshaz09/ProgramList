using ProgramList.Common.Converters;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ProgramList.MSDataGrid.Columns
{
    public static class ColumnExtensions
    {
        //private static Style DefaultCellStyle = Application.Current.FindResource("GridViewCellCoreValidationStyle") as Style;
        private static IValueConverter RGBToBrushConverter = new RGBToBrushConverter();
        public static void ApplyDefaultSettings(this DataGridBoundColumn column, 
            string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            //column.ColumnName = header;

            column.Header = header;
            //column.DataType = dataType;
            //column.Visible = isVisible;
            column.IsReadOnly = isReadOnly;
            column.Binding = new Binding(header);
            //column.IsEnabled = isEnabled;
            //column.Selected = isSelected;
            //column.GroupAggregate = true;

            column.MinWidth = 95;


            //column.Rea = new Binding($"IsReadOnly_{column.FieldName}") { Mode = BindingMode.TwoWay };



            var cellStyle = new Style(typeof(DataGridCell));

            cellStyle.Setters.Add(new Setter(Control.ForegroundProperty, new Binding($"Foreground_{header}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(Control.BackgroundProperty, new Binding($"Background_{header}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"IsEnabled_{header}") { Mode = BindingMode.TwoWay }));
            cellStyle.Setters.Add(new Setter(DataGridCell.IsEditingProperty, new Binding($"IsInEditMode_{header}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(DataGridCell.IsCurrentProperty, new Binding($"IsCurrent_{header}") { Mode = BindingMode.TwoWay }));
            column.CellStyle = cellStyle;



        }
    }
}
