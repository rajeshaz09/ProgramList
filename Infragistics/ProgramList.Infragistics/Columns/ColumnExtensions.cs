using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using ProgramList.Common.Converters;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ProgramList.DevX.Columns
{
    public static class ColumnExtensions
    {
        //private static Style DefaultCellStyle = Application.Current.FindResource("GridViewCellCoreValidationStyle") as Style;
        private static IValueConverter RGBToBrushConverter = new RGBToBrushConverter();
        public static void ApplyDefaultSettings(this GridColumn column, 
            string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            column.FieldName = header;

            column.Header = header;
            //column.DataType = dataType;
            column.Visible = isVisible;
            column.ReadOnly = isReadOnly;
            column.IsEnabled = isEnabled;
            //column.select = isSelected;
            column.AllowGrouping =  DevExpress.Utils.DefaultBoolean.True;

            column.MinWidth = 95;


            //column.Rea = new Binding($"IsReadOnly_{column.FieldName}") { Mode = BindingMode.TwoWay };



            var cellStyle = new Style(typeof(LightweightCellEditor));
            cellStyle.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, new Binding($"Data.Foreground_{column.FieldName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new Binding($"Data.Background_{column.FieldName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"Data.IsEnabled_{column.FieldName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridCell.IsInEditModeProperty, new Binding($"IsInEditMode_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridViewCell.IsCurrentProperty, new Binding($"IsCurrent_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            column.CellStyle = cellStyle;
            


        }
    }
}
