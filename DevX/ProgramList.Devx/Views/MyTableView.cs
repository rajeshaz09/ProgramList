using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.DevX.Views
{
    public class MyTableView : TableView
    {
        protected override void OnColumnHeaderClick(ColumnBase column, bool isShift, bool isCtrl)
        {
            if (isCtrl)
            {
                BeginSelection();
                for (int i = 0; i < Grid.VisibleRowCount; i++)
                    SelectCell(i, column as GridColumn);
                EndSelection();
                return;
            }
            base.OnColumnHeaderClick(column, isShift, isCtrl);
        }
    }
}
