using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace ProgramList.TelerikPOC.Columns
{
    public sealed class ButtonColumnInfo : ColumnInfo
    {
        private ICommand _command;
        public ButtonColumnInfo(string header, Type dataType, ICommand command, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected)
        {
            _command = command;
            CellTemplate = GetCellEditTemplate(UniqueName);
        }

        private static DataTemplate GetCellEditTemplate(string bindingProperty)
        {
            var strTemplate = $@"
                <DataTemplate 
                    xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                    xmlns:telerik=""http://schemas.telerik.com/2008/xaml/presentation""
                    >

                    <telerik:RadButton
                        Content=""{{ Binding {bindingProperty}, Mode = TwoWay }}""
                        CommandParameter=""{{ Binding ., Mode = TwoWay }}""
                        Command=""{{ Binding RelativeSource={{RelativeSource Mode=FindAncestor, AncestorType={{x:Type telerik:RadGridView}}}}, Path=DataContext.Commands[{bindingProperty}], Mode = TwoWay }}""
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
