using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.Themes;
using ProgramList.DevX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ProgramList.DevX.Final
{
    public class ListColumn : GridColumn
	{

		public string ColumnName
		{
			get => GetValue(ColumnNameProperty)?.ToString();
			set
			{
				SetValue(ColumnNameProperty, value);
				UpdateCellStyle();
			}
		}



		public ListColumnSortOrder ColumnSortOrder
		{
			get { return (ListColumnSortOrder)GetValue(ColumnSortOrderProperty); }
			set { SetValue(ColumnSortOrderProperty, value); }
		}

		public static readonly DependencyProperty ColumnSortOrderProperty =
			DependencyProperty.Register("ColumnSortOrder", typeof(ListColumnSortOrder), typeof(ListColumn), new PropertyMetadata(ListColumnSortOrder.Unsorted));



		public static readonly DependencyProperty ColumnNameProperty =
					 DependencyProperty.RegisterAttached("ColumnName", typeof(string), typeof(ListColumn), new PropertyMetadata(PropertyChangedCallbackHandler));
		private static void PropertyChangedCallbackHandler(DependencyObject obj, DependencyPropertyChangedEventArgs args)
		{
			(obj as ListColumn).ColumnName = args.NewValue.ToString();
		}

		public bool IsLinkedProgram
		{
			get { return (bool)GetValue(IsLinkedProgramProperty); }
			set { SetValue(IsLinkedProgramProperty, value); }
		}

		public static readonly DependencyProperty IsLinkedProgramProperty =
				DependencyProperty.Register("IsLinkedProgram", typeof(bool), typeof(ListColumn), new PropertyMetadata(false));

		public String ColumnAlignment
		{
			get { return (String)GetValue(ColumnAlignmentProperty); }
			set { SetValue(ColumnAlignmentProperty, value); }
		}

		public static readonly DependencyProperty ColumnAlignmentProperty =
				DependencyProperty.Register("ColumnAlignment", typeof(String), typeof(ListColumn));

		private static Style DefaultCellStyle = Application.Current.FindResource(new GridRowThemeKeyExtension() { ResourceKey = GridRowThemeKeys.LightweightCellStyle }) as Style;
		private static IValueConverter RGBToBrushValueConverter = new RGBToBrushConverter();
		private static IValueConverter NotNullValueConverter = new NotNullConverter();
		//private static IValueConverter InverseBooleanConverter = new CInverseBooleanConverter();
		private static IValueConverter ReadOnlyListModeConverter = new ReadOnlyListModeConverter();
		private static IValueConverter UnsavedRowConverter = new UnsavedRowConverter();
		object unsavedCellBrush = Application.Current.Resources["GridCellUnsavedForegroundBrush"];
		object gridCellReadonlyBrush = Application.Current.Resources["GridCellReadOnlyBrush"];
		object gridCellSelectionBrush = Application.Current.Resources["GridSelectedCellsBackgroundBrush"];		
		object gridCellDelimiterBrush = Application.Current.Resources["LightBlueBrushWithOpacity"];

		private void UpdateCellStyle()
		{
			
			var cellStyle = new Style
			{
				TargetType = typeof(LightweightCellEditor)
			};

			cellStyle.Setters.Add(new Setter(LightweightCellEditor.BorderBrushProperty, gridCellDelimiterBrush));
			cellStyle.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, null));

			var foregroundTrigger = new DataTrigger()
			{
				Binding = new Binding($"RowData.Row.{ColumnName}.Foreground") { Converter = NotNullValueConverter },
				Value = true
			};
			foregroundTrigger.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, new Binding($"RowData.Row.{ColumnName}.Foreground") { Converter = RGBToBrushValueConverter }));
			cellStyle.Triggers.Add(foregroundTrigger);

			Binding foregroundUnsavedRowBinding = new Binding($"RowData.Row.SelectionState");
			foregroundUnsavedRowBinding.Converter = UnsavedRowConverter;
			var foregroundUnsavedRowTrigger = new DataTrigger()
			{
				Binding = foregroundUnsavedRowBinding,
				Value = true
			};
			foregroundUnsavedRowTrigger.Setters.Add(new Setter(LightweightCellEditorBase.ForegroundProperty, unsavedCellBrush));
			cellStyle.Triggers.Add(foregroundUnsavedRowTrigger);			

			var readonlyTrigger = new DataTrigger()
			{
				Binding = new Binding("Column.ReadOnly"),
				Value = true
			};
			readonlyTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, gridCellReadonlyBrush));
			cellStyle.Triggers.Add(readonlyTrigger);

			var isEnabledTrigger = new DataTrigger()
			{
				Binding = new Binding("Column.IsEnabled"),
				Value = false
			};
			isEnabledTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, gridCellReadonlyBrush));
			cellStyle.Triggers.Add(isEnabledTrigger);

			MultiDataTrigger backgroundFocusedCellTrigger = new MultiDataTrigger();
			Binding modeBinding = new Binding();
			modeBinding.Path = new PropertyPath("DataContext.Mode");
			modeBinding.RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(ProgramListView), 1);
			Binding focusedCellBinding = new Binding("IsFocusedCell") { RelativeSource = new RelativeSource(RelativeSourceMode.Self) };

			backgroundFocusedCellTrigger.Conditions.Add(new Condition(focusedCellBinding, true));
			backgroundFocusedCellTrigger.Conditions.Add(new Condition(modeBinding, "Edit"));
			backgroundFocusedCellTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new SolidColorBrush(Colors.White)));
			cellStyle.Triggers.Add(backgroundFocusedCellTrigger);

			var backgroundTrigger = new DataTrigger()
			{
				Binding = new Binding($"RowData.Row.{ColumnName}.Background") { Converter = NotNullValueConverter },
				Value = true
			};
			backgroundTrigger.Setters.Add(new Setter(LightweightCellEditor.BackgroundProperty, new Binding($"RowData.Row.{ColumnName}.Background") { Converter = RGBToBrushValueConverter }));
			cellStyle.Triggers.Add(backgroundTrigger);

			CellStyle = cellStyle;
		}
	}
}
