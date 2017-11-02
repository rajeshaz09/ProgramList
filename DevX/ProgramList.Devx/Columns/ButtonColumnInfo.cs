using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml;

namespace ProgramList.DevX.Columns
{
    public sealed class ButtonColumnInfo : ColumnInfo
    {
        private ICommand _command;
        public ButtonColumnInfo(string header, Type dataType, ICommand command, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected, bool isLinked)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected, isLinked)
        {
            _command = command;
            CellTemplate = GetCellEditTemplate(UniqueName);

            //var buttonInfo = new ButtonInfo()
            //{
            //    Command = command
            //};
            //buttonInfo.SetBinding(ButtonInfo.ContentProperty, new Binding(FieldName) { Mode = BindingMode.TwoWay });
            //buttonInfo.SetBinding(ButtonInfo.CommandParameterProperty, new Binding(".") { Mode = BindingMode.TwoWay });


            //var buttonSettings = new ButtonEditSettings();
            //buttonSettings.Buttons.Add(buttonInfo);
            //EditSettings = buttonSettings;

        }

        private static DataTemplate GetCellEditTemplate(string bindingProperty)
        {
            var strTemplate = $@"
                <DataTemplate 
                    xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                    xmlns:dx=""http://schemas.devexpress.com/winfx/2008/xaml/core""
                    xmlns:dxg=""http://schemas.devexpress.com/winfx/2008/xaml/grid""
                    >

                    <dx:SimpleButton
                        Content=""{{ Binding RowData.Row.{bindingProperty}, Mode = TwoWay }}""
                        CommandParameter=""{{ Binding RowData.Row, Mode = TwoWay }}""
                        Command=""{{ Binding RelativeSource={{RelativeSource Mode=FindAncestor, AncestorType={{x:Type dxg:GridControl}}}}, Path=DataContext.Commands[{bindingProperty}], Mode = TwoWay }}""
                    />
                </DataTemplate>
            ";
            using (var stringReader = new StringReader(strTemplate))
            {
                {
                    var xmlReader = XmlReader.Create(stringReader);
                    return XamlReader.Load(xmlReader) as DataTemplate;
                }
            }
            //ToDo use convertors and datetime objects use  ToShortTimeString, ToShortDateString

        }
    }
}
