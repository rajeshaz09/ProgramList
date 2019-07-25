using DevExpress.Xpf.Grid;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Data;
using System.Reflection;
using DevExpress.Xpf.Grid.Native;
using ProgramList.DevX.Models;

namespace ProgramList.DevX.Final
{
	public class ListView : TableView
	{
		public IProgramListViewModel viewModel;
		public event EventHandler<ColumnReorderedEventArgs> OnColumnReordered;
		public event EventHandler<EventArgs> OnRowIndicationHeaderClicked;

		public class GridViewInplaceEditorOwnerEx : GridViewInplaceEditorOwner
		{
			public GridViewInplaceEditorOwnerEx(DataViewBase view)
					: base(view)
			{
				
			}
			protected override void FocusProcessMouseDown(DependencyObject originalSource)
			{
				TableViewHitInfo hitInfo = ((TableView)owner).CalcHitInfo(originalSource);
				var rowCount = ((TableView)owner).Grid.VisibleRowCount;
				if (hitInfo.HitTest == TableViewHitTest.VerticalScrollBar || hitInfo.HitTest == TableViewHitTest.HorizontalScrollBar ||
					(hitInfo.HitTest == TableViewHitTest.ColumnHeader && rowCount == 0)) return;
					
				base.FocusProcessMouseDown(originalSource);
			}
		}

		public ListView()
		{
			PropertyInfo inplaceEditorOwnerPropInfo = GetType().GetProperty("InplaceEditorOwner", BindingFlags.Instance | BindingFlags.NonPublic);
			inplaceEditorOwnerPropInfo.SetValue(this, new GridViewInplaceEditorOwnerEx(this));
		}
		protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == VisibleColumnsProperty)
			{
				var oldValue = (e.OldValue as DevExpress.Utils.SimpleBridgeList<GridColumn, ColumnBase>)?.ToList();
				var newValue = (e.NewValue as DevExpress.Utils.SimpleBridgeList<GridColumn, ColumnBase>)?.ToList();
				if (oldValue == null || newValue == null)
					return;
				if (oldValue.Count() != newValue.Count())
					return;

				int oldIndex = 0, newIndex = 0, start = 0, end = oldValue.Count() - 1;
				IColumnInfo column = null;

				while (oldValue[start] == newValue[start])
					start++;
				while (oldValue[end] == newValue[end])
					end--;
				if (oldValue[start] == newValue[end])
				{
					column = oldValue[start].DataContext as IColumnInfo;
					oldIndex = start;
					newIndex = end;
				}
				else
				{
					column = newValue[start].DataContext as IColumnInfo;
					oldIndex = end;
					newIndex = start;
				}

				OnColumnReordered(null, new ColumnReorderedEventArgs(column, oldIndex, newIndex));
			}
		}
		public void UnBindControl()
		{
			BindingOperations.ClearAllBindings(this);
			viewModel = null;
			OnColumnReordered = null;
		}

		protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			var hitInfo = CalcHitInfo(e.OriginalSource as DependencyObject);
			if (hitInfo.HitTest == TableViewHitTest.ColumnButton)
				OnRowIndicationHeaderClicked?.Invoke(null, new EventArgs());
			base.OnPreviewMouseLeftButtonUp(e);
		}

		protected override void OnPreviewMouseDoubleClick(MouseButtonEventArgs e)
		{
			if (!IsLastEmptyColumn(e.OriginalSource))
				base.OnPreviewMouseDoubleClick(e);
		}

		protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
		{
			if (!IsLastEmptyColumn(e.OriginalSource))
				base.OnMouseDoubleClick(e);
		}

		private bool IsLastEmptyColumn(object originalSource)
		{
			var info = CalcHitInfo(originalSource as DependencyObject);
			return info.InRow && info.Column == null && info.HitTest != TableViewHitTest.RowIndicator;
		}
	}
}
