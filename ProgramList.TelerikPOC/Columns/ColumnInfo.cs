using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Columns
{
    public class ColumnInfo : GridViewDataColumn
    {
        public int Ordinal { get; private set; }

        public ColumnInfo(string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
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
