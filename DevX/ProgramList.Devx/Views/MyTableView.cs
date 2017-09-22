using DevExpress.Xpf.Grid;
using ProgramList.Common.Models;
using ProgramList.DevX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Data;

namespace ProgramList.DevX.Views
{
    public class MyTableView : TableView
    {
        private void ApplyIsSelected(bool isSelected, string columnName)
        {
            var viewModel = Grid.DataContext as ProgramListViewModel;
            foreach (var row in viewModel.GridData)
            {
                var model = row as ListItemBase;
                model.SetIsCurrentInternal(isSelected, $"IsCurrent_{columnName}");
            }
        }

        protected override void OnColumnHeaderClick(ColumnBase column, bool isShift, bool isCtrl)
        {
            var columnInfo = column as Columns.ColumnInfo;

            if (isCtrl)
            {
                columnInfo.IsSelected = !columnInfo.IsSelected;

                ApplyIsSelected(columnInfo.IsSelected, columnInfo.FieldName);
                return;
            }
            base.OnColumnHeaderClick(column, isShift, isCtrl);
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            TableViewHitInfo hitInfo = CalcHitInfo(e.OriginalSource as DependencyObject);
            if (hitInfo.InRowCell)
            {
                foreach (var columnInfo in Grid.Columns.Cast<Columns.ColumnInfo>())
                {
                    if (columnInfo.IsSelected)
                    {
                        columnInfo.IsSelected = false;
                        ApplyIsSelected(false, columnInfo.FieldName);
                    }
                }
            }

            base.OnMouseLeftButtonUp(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.Key == Key.M && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                AllowEditing = true;
                foreach (var column in Grid.Columns.Cast<Columns.ColumnInfo>())
                {
                    //if (!column.ReadOnly)
                    //    column.AllowEditing = DevExpress.Utils.DefaultBoolean.True;
                    column.TabStop = !column.ReadOnly;
                    column.AllowFocus = !column.ReadOnly;

                    Commands.EditFocusedRow?.Execute(null);
                }

                e.Handled = true;
            }
            else if (e.Key == Key.Q && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                AllowEditing = false;
                foreach (var column in Grid.Columns.Cast<Columns.ColumnInfo>())
                {
                    //if (!column.ReadOnly)
                    //    column.AllowEditing = DevExpress.Utils.DefaultBoolean.False;
                    column.TabStop = true;
                    column.AllowFocus = true;
                }
                Commands.EndEditFocusedRow?.Execute(null);
                //CommitEditing();

                e.Handled = true;
            }
            else if (e.Key == Key.F && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                e.Handled = false;
            }
            else if (e.Key == Key.N && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                e.Handled = false;
            }
            else if (e.Key == Key.S && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
            {
                e.Handled = false;
            }
            else if (e.Key == Key.F && e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
            {

            }
            else

                base.OnKeyUp(e);
        }
        
    }
}
