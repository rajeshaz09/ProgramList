using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using Prism.Commands;
using ProgramList.Common.DynamicType;
using ProgramList.Common.Models;
using ProgramList.Common.ViewModels;
using ProgramList.DevX.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProgramList.DevX.ViewModels
{
	public class ProgramListViewModel : ProgramListViewModelBase
	{
		public ObservableCollectionCore<object> GridData { get; private set; }

		private IListItemBase _currentRow;
		public IListItemBase CurrentRow
		{
			get { return _currentRow; }
			set { SetProperty(ref _currentRow, value); }
		}

		private ColumnBase _currentColumn;
		public ColumnBase CurrentColumn
		{
			get { return _currentColumn; }
			set { SetProperty(ref _currentColumn, value); }
		}
		#region Commands
		public ICommand PreviewKeyDownCommand { get; private set; }
		public ICommand CurrentColumnChangedCommand { get; private set; }
		public ICommand CurrentRowChangedCommand { get; private set; }
		#endregion Commands

		public ProgramListViewModel(int rows, int columnSets) : base(rows, columnSets)
		{
			PreviewKeyDownCommand = new DelegateCommand<KeyEventArgs>(OnPreviewKeyDownHandler);
			CurrentRowChangedCommand = new DelegateCommand<CurrentItemChangedEventArgs>(OnCurrentRowChangedHandler);
			CurrentColumnChangedCommand = new DelegateCommand<CurrentColumnChangedEventArgs>(OnCurrentColumnChangedHandler);
			GridData = new ObservableCollectionCore<object>();
		}

		private void OnCurrentRowChangedHandler(CurrentItemChangedEventArgs e)
		{
			Trace.WriteLine($"Row Changed  {_currentRow?.RowNumber}");
		}

		private void OnCurrentColumnChangedHandler(CurrentColumnChangedEventArgs e)
		{
			Trace.WriteLine($"Column Changed  {_currentColumn?.FieldName}");
		}

		public ICommand GenerateCommand(string columnName)
		{
			var command = new DelegateCommand<IListItemBase>(
					(model) =>
					{
						OnCommandExecute(columnName, model);
					});

			Commands.Add(columnName, command);
			return command;
		}

		private static void OnCommandExecute(string columnName, IListItemBase model)
		{
			MessageBox.Show($"Row\t{model.RowNumber}{Environment.NewLine}Column\t{columnName}");
		}

		private void OnPreviewKeyDownHandler(KeyEventArgs e)
		{
			if (e.Key == Key.F && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
			{
				e.Handled = true;
			}
		}

	}
}

