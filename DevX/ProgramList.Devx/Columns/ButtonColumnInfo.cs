using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace ProgramList.DevX.Columns
{
    public sealed class ButtonColumnInfo : ColumnInfo
    {
        private ICommand _command;
        public ButtonColumnInfo(string header, Type dataType, ICommand command, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected)
        {
            _command = command;

            var buttonInfo = new ButtonInfo()
            {
                Command = command
            };
            buttonInfo.SetBinding(ButtonInfo.ContentProperty, new Binding(FieldName) { Mode = BindingMode.TwoWay });
            buttonInfo.SetBinding(ButtonInfo.CommandParameterProperty, new Binding(".") { Mode = BindingMode.TwoWay });


            var buttonSettings = new ButtonEditSettings();
            buttonSettings.Buttons.Add(buttonInfo);
            EditSettings = buttonSettings;

        }

        //public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
        //{
        //    RadButton button = cell.Content as RadButton;
        //    if (button == null)
        //    {
        //        button = new RadButton()
        //        {
        //            Command = _command
        //        };
        //        button.SetBinding(ContentControl.ContentProperty, new Binding(UniqueName) { Mode = BindingMode.TwoWay });
        //    }

        //    button.SetBinding(System.Windows.Controls.Primitives.ButtonBase.CommandParameterProperty, new Binding(".") { Mode = BindingMode.TwoWay });

        //    return button;
        //}
    }
}
