using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Grid;
using ProgramList.Common.Models;
using System;
using System.Windows.Data;


namespace ProgramList.DevX.Columns
{
    public sealed class DropDownColumnInfo : ColumnInfo, IColumnInfo
    {
        private DropDownItemCollection _itemsSource;
        public DropDownColumnInfo(string header, Type dataType, DropDownItemCollection itemsSource, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected, bool isLinked)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected, isLinked)
        {
            //this.ApplyDefaultSettings(header, dataType, isVisible, isReadOnly, isEnabled, isSelected);
            _itemsSource = itemsSource;
            EditSettings = new ComboBoxEditSettings()
            {
                ItemsSource = _itemsSource,
                DisplayMember = DropDownItem.NameProperty,
                ValueMember = DropDownItem.IdProperty
            };

            //ItemsSource = _itemsSource;
            //SelectedValueMemberPath = DropDownItem.IdProperty;
            //DisplayMemberPath = DropDownItem.NameProperty;
            //IsLightweightModeEnabled = true;
        }
    }
}
