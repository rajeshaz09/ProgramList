using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Linq.Expressions;
using ProgramList.Common.Models;
using ProgramList.Common.DynamicType;
using ProgramList.Common.ViewModels;
using System.Threading.Tasks;
using ProgramList.DevX.Columns;

namespace ProgramList.DevX.ViewModels
{
    public static class ProgramListViewModelHelper
    {
        private const int MaxColumns = 30;
        private const int MaxRows = 10000;

        internal static ProgramListViewModel GetRunTimeTypeSampleViewModel()
        {

            //ToDo https://stackoverflow.com/questions/2024435/how-to-pass-ctor-args-in-activator-createinstance-or-use-il
            //ToDo https://msdn.microsoft.com/en-us/library/system.reflection.emit.assemblybuilderaccess(v=vs.110).aspx
            //ToDo https://msdn.microsoft.com/en-us/library/dd554932(vs.100).aspx
            //ToDo https://www.codeproject.com/Articles/1118828/Faster-than-Reflection-Delegates-Part

            var viewModel = new ProgramListViewModel();
            //AddSampleColumns(viewModel.AddColumn);

            viewModel.Columns.Add(new ColumnInfo("StringProperty", typeof(string), false, false, true, false));
            viewModel.Columns.Add(new ColumnInfo("IntProperty", typeof(int), true, true, true, false));
            viewModel.Columns.Add(new ColumnInfo("BoolProperty", typeof(bool), true, false, true, false));
            var dropDownDataSource = new DropDownItemCollection()
            {
                new DropDownItem("0", "Zero"),
                new DropDownItem("1", "One"),
                new DropDownItem("2", "Two"),
                new DropDownItem("3", "Three"),
            };

            viewModel.Columns.Add(new DropDownColumnInfo("DropDown", typeof(int), dropDownDataSource, true, false, true, false));

            var chartItemsSource = new ChartPointCollection()
            {
                new ChartPoint(8, "c1"),
                new ChartPoint(18, "c2"),
                new ChartPoint(10, "c3"),
                new ChartPoint(12, "c4"),
                new ChartPoint(18, "c5"),
                new ChartPoint(2, "c6"),
            };

            //viewModel.Columns.Add(new ChartColumnInfo("Chart", typeof(ChartPointCollection), chartItemsSource, true, false, true, false));

            viewModel.Columns.Add(new ButtonColumnInfo("Button1", typeof(string), viewModel.GenerateCommand("Button1"), true, false, true, false));
            viewModel.Columns.Add(new ButtonColumnInfo("Button2", typeof(string), viewModel.GenerateCommand("Button2"), true, false, true, false));
            //viewModel.Columns.Add(new ImageColumnInfo("Image", typeof(string), true, false, true, false));

            //viewModel.Columns.Add(new DateTimeColumnInfo("DateTimeProperty", typeof(string), InputMode.DateTimePicker, true, false, true, false));

            //viewModel.Columns.Add(new DateTimeColumnInfo("DateProperty", typeof(string), InputMode.DatePicker, true, false, true, false));

            //viewModel.Columns.Add(new DateTimeColumnInfo("TimeProperty", typeof(string), InputMode.TimePicker, true, false, true, false));


            for (var i = 1; i <= MaxColumns; i++)
            {
                viewModel.Columns.Add(new ColumnInfo($"StringProperty{i}", typeof(string), true, false, true, false));
                viewModel.Columns.Add(new ColumnInfo($"IntProperty{i}", typeof(int), true, false, true, false));
                viewModel.Columns.Add(new ColumnInfo($"BoolProperty{i}", typeof(bool), true, false, true, false));
            }
            RunTimeTypeHelper.CreateAssembly(viewModel.TypeName, viewModel.Columns);

            return viewModel;
        }

        internal static void ClearAndAssignData(ProgramListViewModel viewModel)
        {
            AssignData(viewModel, true);
        }

        private static int seed = 0;
        public static void AssignData(ProgramListViewModel viewModel, bool ClearOld = false)
        {
            var objectExpression = RunTimeTypeHelper.GenerateObjectExpression($"{viewModel.TypeName}.dll");

            if (ClearOld)
                viewModel.GridData.Clear();

            var gridData = viewModel.GridData;

            viewModel.GridData.BeginUpdate();
            //using (var gridData = viewModel.GridData.DelayNotifications())
            {
                for (var index = 1; index <= MaxRows; index++)
                {
                    var row = index + seed;
                    //parameters[1] = row;
                    //var model = (ListItemBase)Activator.CreateInstance(ass.GetType("Jeeves.CustomModels.MyType", true), parameters);


                    var model = objectExpression(viewModel.Columns, row);
                    model.SetValue(row % 4, "DropDown");
                    model.SetValue(row, "IntProperty");
                    model.SetValue($"String{row}", "StringProperty");
                    model.SetValue(row % 2 == 0, "BoolProperty");
                    model.SetValue($"1 R {row}", "Button1");
                    model.SetValue($"2 R {row}", "Button2");

                    //if (row == 1)
                    //{
                    //    //model.SetValue(@"pack://application:,,,/Images/Add.png", "Image");
                    //    //model.SetValue(chartItemsSource, "Chart");
                    //}


                    //var model = new Jeeves.CustomModels.MyType(viewModel.Columns, row);
                    //model.DropDown = row % 4;
                    //model.IntProperty = row;
                    //model.StringProperty = $"String{row}";
                    //model.BoolProperty = (row % 2 == 0);
                    //model.Button1 = $"1 R {row}";
                    //model.Button2 = $"2 R {row}";

                    //batchList.Add(model);
                    if (row == 1)
                    {
                        model.SetBackground("#EC2B2B", "StringProperty1");
                        model.SetForeground("#FFFFFF", "StringProperty1");
                    }
                    gridData.Add(model);

                    //await Task.Delay(0);
                }
            }
            seed += MaxRows;


            viewModel.GridData.EndUpdate();
        }
    }
}

