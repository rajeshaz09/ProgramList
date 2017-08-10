using ProgramList.TelerikPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using Telerik.Windows.Controls;
using ProgramList.TelerikPOC.Columns;

namespace ProgramList.TelerikPOC.ViewModels
{
    public static class ProgramListViewModelHelper
    {
        private const int MaxColumns = 3;
        private const int VisibleColumns = 3;
        private const int MaxRows = 3;

        internal static ProgramListViewModel<ListItemBase> GetRunTimeTypeSampleViewModel()
        {

            //ToDo https://stackoverflow.com/questions/2024435/how-to-pass-ctor-args-in-activator-createinstance-or-use-il
            //ToDo https://msdn.microsoft.com/en-us/library/system.reflection.emit.assemblybuilderaccess(v=vs.110).aspx
            //ToDo https://msdn.microsoft.com/en-us/library/dd554932(vs.100).aspx
            //ToDo https://www.codeproject.com/Articles/1118828/Faster-than-Reflection-Delegates-Part

            var viewModel = new ProgramListViewModel<ListItemBase>();
            //AddSampleColumns(viewModel.AddColumn);

            viewModel.Columns.Add(new ColumnInfo("StringProperty", typeof(string), false, false, true, false));
            viewModel.Columns.Add(new ColumnInfo("IntProperty", typeof(int), true, true, true, false));
            viewModel.Columns.Add(new ColumnInfo("BoolProperty", typeof(bool), true, false, true, false) { TabStopMode = Telerik.Windows.Controls.GridView.GridViewTabStop.Skip });
            var dropDownDataSource = new DropDownModel()
            {
                new DropDownItem("0", "Zero"),
                new DropDownItem("1", "One"),
                new DropDownItem("2", "Two"),
                new DropDownItem("3", "Three"),
            };

            viewModel.Columns.Add(new DropDownColumnInfo("DropDown", typeof(int), dropDownDataSource, true, false, true, false));

            var chartItemsSource = new ChartModel()
            {
                new ChartPoint(8, "c1"),
                new ChartPoint(18, "c2"),
                new ChartPoint(10, "c3"),
                new ChartPoint(12, "c4"),
                new ChartPoint(18, "c5"),
                new ChartPoint(2, "c6"),
            };

            viewModel.Columns.Add(new ChartColumnInfo("Chart", typeof(ChartModel), chartItemsSource, true, false, true, false));

            viewModel.Columns.Add(new ButtonColumnInfo("Button", typeof(int), viewModel.GenerateCommand("Button"), true, false, true, false));
            viewModel.Columns.Add(new ButtonColumnInfo("Button1", typeof(int), viewModel.GenerateCommand("Button1"), true, false, true, false));
            viewModel.Columns.Add(new ImageColumnInfo("Image", typeof(string), true, false, true, false));

            viewModel.Columns.Add(new DateTimeColumnInfo("DateTimeProperty", typeof(string), InputMode.DateTimePicker, true, false, true, false));

            viewModel.Columns.Add(new DateTimeColumnInfo("DateProperty", typeof(string), InputMode.DatePicker, true, false, true, false));

            viewModel.Columns.Add(new DateTimeColumnInfo("TimeProperty", typeof(string), InputMode.TimePicker, true, false, true, false));


            for (var i = 1; i <= MaxColumns; i++)
            {
                viewModel.Columns.Add(new ColumnInfo($"StringProperty{i}", typeof(string), true, false, true, false));
                viewModel.Columns.Add(new ColumnInfo($"IntProperty{i}", typeof(int), true, false, true, false));
                viewModel.Columns.Add(new ColumnInfo($"BoolProperty{i}", typeof(bool), true, false, true, false));
            }

            RunTimeTypeHelper.CreateAssembly("Jeeves.CustomModels.MyType", viewModel.Columns);

            var ass = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(assembly => assembly.GetName().Name == "Jeeves.CustomModels.MyType.dll");

            var parameters = new object[] { viewModel.Columns, -1 };
            var paramTypes = new[] { Expression.Parameter(RunTimeTypeHelper.ConstructorParameterTypeList[0]),
                Expression.Parameter(RunTimeTypeHelper.ConstructorParameterTypeList[1]) };
            var objectExpression = Expression.Lambda<Func<IList<GridViewBoundColumnBase>, int, ListItemBase>>
                 (Expression
                 .New(ass.DefinedTypes.First().GetConstructor(RunTimeTypeHelper.ConstructorParameterTypeList), paramTypes)
                 , paramTypes)
                 .Compile();

            for (var row = 1; row <= MaxRows; row++)
            {
                //parameters[1] = row;
                //var model = (ListItemBase)Activator.CreateInstance(ass.GetType("Jeeves.CustomModels.MyType", true), parameters);
                var model = objectExpression(viewModel.Columns, row);
               
                if (row == 1)
                {
                    model.SetValue(@"pack://application:,,,/Images/Add.png", "Image");
                    model.SetValue(chartItemsSource, "Chart");
                }
                viewModel.GridData.Add(model);
            }
            return viewModel;
        }

        internal static ProgramListViewModel<INotifyPropertyChanged> GetCompileTimeTypeSampleViewModel()
        {

            var viewModel = new ProgramListViewModel<INotifyPropertyChanged>();

            var parameters = new object[] { new List<GridViewBoundColumnBase>() };

            for (var row = 1; row <= MaxRows; row++)
            {
                var model = new NormalModel((List<GridViewBoundColumnBase>)parameters[0], row);
                viewModel.GridData.Add(model);
            }
            return viewModel;
        }

    }
}

