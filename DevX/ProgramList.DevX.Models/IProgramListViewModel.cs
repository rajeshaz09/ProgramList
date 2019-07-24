using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Utils;
using DevExpress.Mvvm;

namespace ProgramList.DevX.Models
{

    public interface IProgramListViewModel : IDisposable
	{
		DynamicModelCollection<DynamicModel> GridData { get; set; }
		ObservableCollectionCore<IColumnInfo> Columns { get; set; }
		Dictionary<string, DropDownItemCollection> ComboBoxDictionary { get; set; }
		void UpdateDescriptors(IList<IColumnInfo> columns);
	}

	public enum RowState
	{
		Invalidate,
		GotData,
		NotRequested
	}

	[Flags]
	public enum SelectionState
	{
		Unknown = 0,
		Unsaved = 1,
		Marked = 2
	}

	public enum DataOperation
	{
		None,
		CopyToClipboard,
		DataFiltering,
		Grouping
	}

	public class FocusChangedEventArgs
	{
		public bool IsGotFocus { get; private set; }
		public FocusChangedEventArgs(bool isGotFocus)
		{
			IsGotFocus = isGotFocus;
		}
	}

	public class CellChangedEventArgs : EventArgs
	{
		public IListItemBase Row { get; }
		public IColumnInfo Column { get; }

		public CellChangedEventArgs(IListItemBase row, IColumnInfo column)
		{
			Row = row;
			Column = column;
		}
	}

	public class ColumnReorderedEventArgs : EventArgs
	{
		public IColumnInfo Column { get; }
		public int OldIndex { get; }
		public int NewIndex { get; }

		public ColumnReorderedEventArgs(IColumnInfo column, int oldIndex, int newIndex)
		{
			Column = column;
			OldIndex = oldIndex;
			NewIndex = newIndex;
		}
	}
	public class TreeListClearEventArgs : EventArgs
	{
		public TreeListClearEventArgs(int noOfRows)
		{
			NoOfRows = noOfRows;
		}
		public int NoOfRows { get; private set; }
		
	}
	public class TreeListSetRowEventArgs : EventArgs
	{
		public TreeListSetRowEventArgs(Dictionary<int, List<string>> rowDictionary)
		{
			TreeListrowDictionary = rowDictionary;
		}
		public Dictionary<int, List<string>> TreeListrowDictionary { get; private set; }

	}
	public interface IIntellisenseService
	{
		void SetItemsSource(object dataContext);
		void RestoreFocusToList(bool isSetFocus, string callbackValue);
		void FocusFirstRow();
	}
}
