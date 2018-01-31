using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;
using System;
using System.IO;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml;

namespace ProgramList.DevX.Columns
{
	public sealed class DateTimeColumnInfo : ColumnInfo
	{
		public string Format { get; set; }
		public DateTimeColumnInfo(string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected, bool isLinked, string format = "dd-mm-yyyy")
				: base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected, isLinked)
		{
			Format = format;
			if (Format == "hh:mm")
			{
				EditSettings = new DateEditSettings() { Mask="hh:mm", MaskUseAsDisplayFormat = true , StyleSettings= new DateEditPickerStyleSettings() };
			}
			if (Format == "dd-mm-yyyy hh:mm")
			{
				EditSettings = new DateEditSettings() { Mask = "g", MaskUseAsDisplayFormat = true, StyleSettings = new DateEditPickerStyleSettings() };
			}
			//CellEditTemplate = GetCellEditTemplate(UniqueName, pickerType);
			//CellTemplate = CellEditTemplate;
		}

		private static DataTemplate GetCellEditTemplate(string bindingProperty, InputMode pickerType)
		{
			var strTemplate = $@"
                <DataTemplate 
                    xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                    xmlns:telerik=""http://schemas.telerik.com/2008/xaml/presentation""
                    >

                    <telerik:RadDateTimePicker TimeInterval=""00:15""
                        ParseExact = ""True""
                        InputMode =""{pickerType.ToString()}""  
                        SelectedValue=""{{ Binding {bindingProperty}, Mode = TwoWay }}""
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
