﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Xml;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Columns
{
    public class DateTimeColumnInfo : ColumnInfo
    {
        public DateTimeColumnInfo(string header, Type dataType, InputMode pickerType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected)
        {
            CellEditTemplate = GetCellEditTemplate(UniqueName, pickerType);
            CellTemplate = CellEditTemplate;
        }

        private static DataTemplate GetCellEditTemplate(string bindingProperty, InputMode pickerType)
        {
            var stringReader = new StringReader(
            $@"
                <DataTemplate 
                    xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                    xmlns:telerik=""http://schemas.telerik.com/2008/xaml/presentation""
                    >

                    <telerik:RadDateTimePicker 
                        ParseExact = ""True""
                        InputMode =""{pickerType.ToString()}""  
                        SelectedValue=""{{ Binding {bindingProperty}, Mode = TwoWay }}""
                    />
                </DataTemplate>
            ");
            var xmlReader = XmlReader.Create(stringReader);
            return XamlReader.Load(xmlReader) as DataTemplate;

            //ToDo use convertors and datetime objects use  ToShortTimeString, ToShortDateString

        }
    }
}
