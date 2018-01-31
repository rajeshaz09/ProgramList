using DevExpress.Xpf.Grid;
using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.DevX.Columns
{
    public class ColumnInfo : GridColumn, IColumnInfo
    {
        public int Ordinal { get; }
        public string UniqueName { get; set; }
        public Type DataType { get; set; }
        public bool IsSelected { get; set; }
        public bool IsLinked { get; }

        public ColumnInfo(string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected, bool isLinked)
        {
            UniqueName = header;
            DataType = dataType;
            IsSelected = isSelected;
            IsLinked = isLinked;
            this.ApplyDefaultSettings(header, dataType, isVisible, isReadOnly, isEnabled, isSelected);
        }
    }

    //ToDo
    //GridViewExpressionColumn http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/expression-column
    //GridViewHyperlinkColumn http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-hyperlink-column
    //GridViewDynamicHyperlinkColumn http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-dynamic-hyperlink-column
    //GridViewCheckBoxColumn http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/checkbox-column
    //GridViewMaskedInputColumn http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-masked-input-column
    //GridViewSelectColumn http://docs.telerik.com/devtools/wpf/controls/radgridview/columns/columntypes/column-types-select-column



}
