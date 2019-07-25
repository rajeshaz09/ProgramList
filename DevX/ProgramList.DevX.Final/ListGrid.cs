using DevExpress.Xpf.Grid;
using ProgramList.DevX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProgramList.DevX.Final
{
	public class ListGrid: GridControl
	{
		protected bool locker;
		public event EventHandler<CellChangedEventArgs> CurrentCellChanged;

		public ListGrid()
		{
			Loaded += OnLoadedHandler;
			Unloaded += OnUnloadedHandler;
		}

		private void OnUnloadedHandler(object sender, RoutedEventArgs e)
		{
			CurrentColumnChanged -= Grid_CurrentColumnChanged;
			CurrentItemChanged -= Grid_CurrentItemChanged;
		}

		private void OnLoadedHandler(object sender, RoutedEventArgs e)
		{
			CurrentColumnChanged -= Grid_CurrentColumnChanged;
			CurrentItemChanged -= Grid_CurrentItemChanged;
			CurrentColumnChanged += Grid_CurrentColumnChanged;
			CurrentItemChanged += Grid_CurrentItemChanged;
		}

		private void Grid_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
		{
			RaiseCurrentCellChanged();
		}

		private void Grid_CurrentColumnChanged(object sender, CurrentColumnChangedEventArgs e)
		{
			RaiseCurrentCellChanged();
		}

		private void RaiseCurrentCellChanged()
		{
			if (!IsLoaded) return;
			if (!locker)
			{
				locker = true;
				Dispatcher.BeginInvoke(new Action(() =>
				{
					CurrentCellChanged?.Invoke(this, new CellChangedEventArgs(
						CurrentItem as IListItemBase,
						CurrentColumn?.DataContext as IColumnInfo));
					locker = false;
				}));

			}
		}
	}
}
