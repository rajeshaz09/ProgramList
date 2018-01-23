using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.Themes;
using ProgramList.Common.Converters;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace ProgramList.DevX.Columns
{
    public static class ColumnExtensions
    {
        private static Style DefaultCellStyle = Application.Current.FindResource(new GridRowThemeKeyExtension() { ResourceKey = GridRowThemeKeys.LightweightCellStyle }) as Style;

        private static SolidColorBrush SelectedColumnForeground = new SolidColorBrush(Colors.Green);
        private static SolidColorBrush SelectedColumnBackground = new SolidColorBrush(Colors.Yellow);
        private static IValueConverter RGBToBrushValueConverter = new RGBToBrushConverter();
        private static IValueConverter NotNullValueConverte = new NotNullConverter();
        public static void ApplyDefaultSettings(this GridColumn column,
            string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            column.FieldName = header;
            column.ShowCriteriaInAutoFilterRow = true;
            column.Header = header;
            //column.DataType = dataType;
            column.Visible = isVisible;
            column.ReadOnly = isReadOnly;
            column.IsEnabled = isEnabled;
            if (column.ReadOnly)
                column.AllowEditing = DevExpress.Utils.DefaultBoolean.False;
            column.TabStop = true;

            //column.select = isSelected;
            column.AllowGrouping = DevExpress.Utils.DefaultBoolean.True;

            column.MinWidth = 95;
            column.Binding = new Binding($"RowData.Row.{column.FieldName}.Data") { Mode = BindingMode.TwoWay };

            //column.Rea = new Binding($"IsReadOnly_{column.FieldName}") { Mode = BindingMode.TwoWay };

            var cellStyle = new Style
            {
                BasedOn = DefaultCellStyle,
                TargetType = typeof(LightweightCellEditor)
            };

            //cellStyle.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, new Binding($"Data.{column.FieldName}.Foreground") { Mode = BindingMode.TwoWay, Converter = RGBToBrushValueConverter }));
            //cellStyle.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new Binding($"Data.{column.FieldName}.Background") { Mode = BindingMode.TwoWay, Converter = RGBToBrushValueConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"RowData.Row.{column.FieldName}.IsEnabled") { Mode = BindingMode.TwoWay }));

            var isCurrentTrigger = new DataTrigger()
            {
                Binding = new Binding($"RowData.Row.{column.FieldName}.IsCurrent"),
                Value = true
            };
            isCurrentTrigger.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, SelectedColumnForeground));
            isCurrentTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, SelectedColumnBackground));
            cellStyle.Triggers.Add(isCurrentTrigger);

            var foregroundTrigger = new DataTrigger()
            {
                Binding = new Binding($"RowData.Row.{column.FieldName}.Foreground") { Converter = NotNullValueConverte },
                Value = true
            };
            foregroundTrigger.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, new Binding($"RowData.Row.{column.FieldName}.Foreground") { Converter = RGBToBrushValueConverter }));
            cellStyle.Triggers.Add(foregroundTrigger);

            var backgroundTrigger = new DataTrigger()
            {
                Binding = new Binding($"RowData.Row.{column.FieldName}.Background") { Converter = NotNullValueConverte },
                Value = true
            };
            backgroundTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new Binding($"RowData.Row.{column.FieldName}.Background") { Converter = RGBToBrushValueConverter }));
            cellStyle.Triggers.Add(backgroundTrigger);

            column.CellStyle = cellStyle;



        }
    }
}
