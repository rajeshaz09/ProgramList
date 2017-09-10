using Prism.Commands;
using ProgramList.Common.Models;
using ProgramList.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProgramList.Infragistics.ViewModels
{
    public class ProgramListViewModel : ProgramListViewModelBase
    {
        public ObservableCollection<ListItemBase> GridData { get; private set; }

        #region Commands
        public ICommand PreviewKeyDownCommand { get; set; }
        public readonly IDictionary<string, ICommand> Commands;
        #endregion Commands

        public ProgramListViewModel()
        {
            PreviewKeyDownCommand = new DelegateCommand<KeyEventArgs>(OnPreviewKeyDownHandler);
            Commands = new Dictionary<string, ICommand>();
            GridData = new ObservableCollection<ListItemBase>();
        }

        public ICommand GenerateCommand(string columnName)
        {
            var command = new DelegateCommand<ListItemBase>(
                (model) =>
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
        }

    }
}
