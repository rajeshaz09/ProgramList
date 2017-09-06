using ProgramList.Common.Models;
using System;
using System.Windows.Data;

namespace ProgramList.DevX.Columns
{
    public sealed class DropDownColumnInfo : ColumnInfo, IColumnInfo
    {
        private DropDownItemCollection _itemsSource;
        public DropDownColumnInfo(string header, Type dataType, DropDownItemCollection itemsSource, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected)
        {
            //this.ApplyDefaultSettings(header, dataType, isVisible, isReadOnly, isEnabled, isSelected);
            //_itemsSource = itemsSource;

            //ItemsSource = _itemsSource;
            //SelectedValueMemberPath = DropDownItem.IdProperty;
            //DisplayMemberPath = DropDownItem.NameProperty;
            //IsLightweightModeEnabled = true;
        }
    }
}
