using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProgramList.DevX.Views
{
    public class MyTableView : TableView
    {
        protected override void OnColumnHeaderClick(ColumnBase column, bool isShift, bool isCtrl)
        {
            var columnInfo = column as Columns.ColumnInfo;

            if (isCtrl)
            {
                columnInfo.IsSelected = !columnInfo.IsSelected;
                DataControl.BeginSelection();
                for (int i = 0; i < Grid.VisibleRowCount; i++)
                {
                    if (columnInfo.IsSelected)
                        SelectCell(i, columnInfo);
                    else
                        UnselectCell(i, columnInfo);
                }
                DataControl.EndSelection();
                return;
            }
            base.OnColumnHeaderClick(column, isShift, isCtrl);
        }
        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            TableViewHitInfo hitInfo = CalcHitInfo(e.OriginalSource as DependencyObject);
            if (hitInfo.InRowCell)
            {
                foreach ( var column in Grid.Columns.Cast<Columns.ColumnInfo>())
                {
                    if (column.IsSelected)
                    {
                        column.IsSelected = false;
                    }
                }
            }

        }
    }
}
