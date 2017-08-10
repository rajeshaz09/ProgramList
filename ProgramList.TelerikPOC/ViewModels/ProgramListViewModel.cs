using Prism.Commands;
using ProgramList.TelerikPOC.Columns;
using ProgramList.TelerikPOC.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.ViewModels
{
    public class ProgramListViewModel<T>: ModelBase
    {
        public ObservableCollection<GridViewBoundColumnBase> Columns { get; set; }

        public ObservableCollection<T> GridData { get; private set; }

        #region Commands
        public ICommand AutoGeneratingColumnCommand { get; set; }
        public ICommand PreviewKeyDownCommand { get; set; }
        public IDictionary<string, ICommand> Commands;
        #endregion Commands

        public ProgramListViewModel()
        {
            Columns = new ObservableCollection<GridViewBoundColumnBase>();
            GridData = new ObservableCollection<T>();
            AutoGeneratingColumnCommand = new DelegateCommand<GridViewAutoGeneratingColumnEventArgs>(OnCustomizeGridExecuted);
            PreviewKeyDownCommand = new DelegateCommand<KeyEventArgs>(OnPreviewKeyDownHandler);
            Commands = new Dictionary<string, ICommand>();
        }

        public ICommand GenerateCommand(string columnName)
        {
            var command = new DelegateCommand<ListItemBase>(
                (model)=> 
                {
                    OnCommandExecute(columnName, model);
                });

            Commands.Add(columnName, command);
            return command;
        }

        private void OnCommandExecute(string columnName, ListItemBase model)
        {
            MessageBox.Show($"Row\t{model.RowNumber}{Environment.NewLine}Column\t{columnName}");
        }
        private void OnCustomizeGridExecuted(GridViewAutoGeneratingColumnEventArgs e)
        {
            e.Column.DataContext = Columns
                    .FirstOrDefault(column => column.UniqueName == e.Column.UniqueName);
            e.Column.Style = Application.Current.TryFindResource("GridViewColumnStyle") as Style;
        }

        private void OnPreviewKeyDownHandler(KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                RadGridViewCommands.CommitEdit.Execute(null);
                RadGridViewCommands.MoveLeft.Execute(null);
                RadGridViewCommands.SelectCurrentUnit.Execute(null);
                Application.Current.Dispatcher.BeginInvoke((Action)(() => RadGridViewCommands.BeginEdit.Execute(null)), System.Windows.Threading.DispatcherPriority.Input);

                e.Handled = true;
            }

            else if (e.Key == Key.Right)
            {
                RadGridViewCommands.CommitEdit.Execute(null);
                RadGridViewCommands.MoveRight.Execute(null);
                RadGridViewCommands.SelectCurrentUnit.Execute(null);
                Application.Current.Dispatcher.BeginInvoke((Action)(() => RadGridViewCommands.BeginEdit.Execute(null)), System.Windows.Threading.DispatcherPriority.Input);

                e.Handled = true;
            }
            else if (e.Key == Key.Up)
            {
                RadGridViewCommands.CommitEdit.Execute(null);
                RadGridViewCommands.MoveUp.Execute(null);
                RadGridViewCommands.SelectCurrentUnit.Execute(null);
                Application.Current.Dispatcher.BeginInvoke((Action)(() => RadGridViewCommands.BeginEdit.Execute(null)), System.Windows.Threading.DispatcherPriority.Input);

                e.Handled = true;
            }
            else if (e.Key == Key.Down)
            {
                RadGridViewCommands.CommitEdit.Execute(null);
                RadGridViewCommands.MoveDown.Execute(null);
                RadGridViewCommands.SelectCurrentUnit.Execute(null);
                Application.Current.Dispatcher.BeginInvoke((Action)(() => RadGridViewCommands.BeginEdit.Execute(null)), System.Windows.Threading.DispatcherPriority.Input);

                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        public void AddColumn(string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            Columns.Add(new ColumnInfo(header, dataType, isVisible, isReadOnly, isEnabled, isSelected));
        }


    }
}

