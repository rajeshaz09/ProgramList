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


            //column.Rea = new Binding($"IsReadOnly_{column.FieldName}") { Mode = BindingMode.TwoWay };

            var cellStyle = new Style
            {
                BasedOn = DefaultCellStyle,
                TargetType = typeof(LightweightCellEditor)
            };

            //cellStyle.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, new Binding($"Data.Foreground_{column.FieldName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushValueConverter }));
            //cellStyle.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new Binding($"Data.Background_{column.FieldName}") { Mode = BindingMode.TwoWay, Converter = RGBToBrushValueConverter }));
            cellStyle.Setters.Add(new Setter(UIElement.IsEnabledProperty, new Binding($"Data.IsEnabled_{column.FieldName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridCell.IsInEditModeProperty, new Binding($"IsInEditMode_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            //cellStyle.Setters.Add(new Setter(GridViewCell.IsCurrentProperty, new Binding($"IsCurrent_{column.UniqueName}") { Mode = BindingMode.TwoWay }));
            var isCurrentTrigger = new DataTrigger()
            {
                Binding = new Binding($"RowData.Row.IsCurrent_{column.FieldName}"),
                Value = true
            };
            isCurrentTrigger.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, SelectedColumnForeground));
            isCurrentTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, SelectedColumnBackground));
            cellStyle.Triggers.Add(isCurrentTrigger);

            var foregroundTrigger = new DataTrigger()
            {
                Binding = new Binding($"RowData.Row.Foreground_{column.FieldName}") { Converter = NotNullValueConverte },
                Value = true
            };
            foregroundTrigger.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, new Binding($"Data.Foreground_{column.FieldName}") { Converter = RGBToBrushValueConverter }));
            cellStyle.Triggers.Add(foregroundTrigger);

            var backgroundTrigger = new DataTrigger()
            {
                Binding = new Binding($"RowData.Row.Background_{column.FieldName}") { Converter = NotNullValueConverte },
                Value = true
            };
            backgroundTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new Binding($"Data.Background_{column.FieldName}") { Converter = RGBToBrushValueConverter }));
            cellStyle.Triggers.Add(backgroundTrigger);

            column.CellStyle = cellStyle;



        }
    }
}
