using Prism.Commands;
using ProgramList.Common.Models;
using ProgramList.Common.ViewModels;
using ProgramList.TelerikPOC.Columns;
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
    public class ProgramListViewModel: ProgramListViewModelBase
    {

        #region Commands
        public ICommand PreviewKeyDownCommand { get; set; }
        public readonly IDictionary<string, ICommand> Commands;
        #endregion Commands

        public ProgramListViewModel()
        {
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

        private static void OnCommandExecute(string columnName, ListItemBase model)
        {
            MessageBox.Show($"Row\t{model.RowNumber}{Environment.NewLine}Column\t{columnName}");
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

    }
}

