using ProgramList.TelerikPOC.Models;
using System;
using System.Windows.Data;

namespace ProgramList.TelerikPOC.Columns
{
    public class DropDownColumnInfo: Telerik.Windows.Controls.GridViewComboBoxColumn
    {
        private DropDownModel _itemsSource;
        public DropDownColumnInfo(string header, Type dataType, DropDownModel itemsSource, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            this.ApplyDefaultSettings(header, dataType, isVisible, isReadOnly, isEnabled, isSelected);
            _itemsSource = itemsSource;

            ItemsSource = _itemsSource;
            SelectedValueMemberPath = DropDownItem.IdProperty;
            DisplayMemberPath = DropDownItem.NameProperty;
        }
    }
}
