using Jeeves.CustomModels;
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

namespace ProgramList.C1FlexGrid.ViewModels
{
    public class ProgramListViewModel : ProgramListViewModelBase
    {
        public ObservableCollection<ListItemBase> GridData { get; private set; }

        #region Commands
        public ICommand PreviewKeyDownCommand { get; set; }
        #endregion Commands

        public ProgramListViewModel(int rows, int columnSets):base(rows, columnSets)
        {
            PreviewKeyDownCommand = new DelegateCommand<KeyEventArgs>(OnPreviewKeyDownHandler);
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
