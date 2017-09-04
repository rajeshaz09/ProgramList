using System;
using Telerik.Windows.Controls;

namespace ScrollIntoViewAsyncMvvm
{
    public sealed class DropDownColumnInfo : GridViewComboBoxColumn
    {
        public DropDownColumnInfo(DropDownItemCollection itemsSource)
        {
            ItemsSource = itemsSource;
            SelectedValueMemberPath = DropDownItem.IdProperty;
            DisplayMemberPath = DropDownItem.NameProperty;
            IsLightweightModeEnabled = true;
        }
    }
}
