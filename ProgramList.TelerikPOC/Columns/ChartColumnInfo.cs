using ProgramList.Common.Models;
using System;
using System.IO;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Xml;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Columns
{
    public sealed class ChartColumnInfo : ColumnInfo
    {
        private ChartPointCollection _itemsSource;
        public ChartColumnInfo(string header, Type dataType, ChartPointCollection itemsSource, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
            : base(header, dataType, isVisible, isReadOnly, isEnabled, isSelected)
        {
            _itemsSource = itemsSource;
            CellTemplate = GetCellEditTemplate(UniqueName);
            //CellEditTemplate = CellEditTemplate;
            Width = 200;
            
        }

        private static DataTemplate GetCellEditTemplate(string bindingProperty)
        {
               var strTemplate = $@"
                <DataTemplate 
                    xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                    xmlns:telerik=""clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Chart""
                    xmlns:chartView=""clr-namespace:Telerik.Windows.Controls.ChartView;assembly=Telerik.Windows.Controls.Chart""
                    
                    >

                    <telerik:RadCartesianChart EmptyContent=""No Data"" >
                        <telerik:RadCartesianChart.VerticalAxis>
                            <chartView:LinearAxis />
                        </telerik:RadCartesianChart.VerticalAxis>

                        <telerik:RadCartesianChart.HorizontalAxis>
                            <chartView:CategoricalAxis />
                        </telerik:RadCartesianChart.HorizontalAxis>

                        <telerik:RadCartesianChart.Series>
                            <chartView:LineSeries 
                                ItemsSource = ""{{ Binding {bindingProperty}, Mode = TwoWay }}"" 
                                ValueBinding = ""{ ChartPoint.ValueProperty }"" 
                                CategoryBinding = ""{ ChartPoint.CategoryProperty }"" 
                            />
                        </telerik:RadCartesianChart.Series>
                    </telerik:RadCartesianChart>
                </DataTemplate>
            ";
            using (var stringReader = new StringReader(strTemplate))
            {
                var xmlReader = XmlReader.Create(stringReader);
                return XamlReader.Load(xmlReader) as DataTemplate;
            }
        }
    }
}
