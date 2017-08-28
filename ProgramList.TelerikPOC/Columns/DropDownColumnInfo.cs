using ProgramList.Common.Models;
using System;
using System.Windows.Data;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Columns
{
    public sealed class DropDownColumnInfo: GridViewComboBoxColumn, IColumnInfo
    {
        private DropDownItemCollection _itemsSource;
        public DropDownColumnInfo(string header, Type dataType, DropDownItemCollection itemsSource, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            this.ApplyDefaultSettings(header, dataType, isVisible, isReadOnly, isEnabled, isSelected);
            _itemsSource = itemsSource;

            ItemsSource = _itemsSource;
            SelectedValueMemberPath = DropDownItem.IdProperty;
            DisplayMemberPath = DropDownItem.NameProperty;
            IsLightweightModeEnabled = true;
        }
    }
}
