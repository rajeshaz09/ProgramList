using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;

namespace ProgramList.DevX.Models
{
	public interface IColumnInfo
	{
		int UniqueId { get; set; }
		EditorType EditSettings { get; set; }
		bool Visible { get; set; }
		string Table { get; }
		string Field { get; }
		int SequenceId { get; }
		bool IsLinkedProgram { get; }
		string WindowContext { get; }
		bool Bound { get; set; }
		string FieldName { get; set; }
		string ColumnName { get; }
		string ColumnAlignment { get; set; }
		string Header { get; set; }
		bool ReadOnly { get; set; }
		bool IsEnabled { get; set; }
		DefaultBoolean AllowEditing { get; set; }
		bool TabStop { get; set; }
		bool AllowFocus { get; set; }
		DefaultBoolean AllowGrouping { get; set; }
		DefaultBoolean AllowSorting { get; set; }
		ListColumnSortOrder ColumnSortOrder { get; set; }
		double MinWidth { get; set; }
		double Width { get; set; }
		bool AutoWidth { get; set; }
		int GroupIndex { get; set; }
		int ServerIndex { get; set; }
		bool IsSelected { get; set; }
		object SearchText { get; set; }
		string SearchToolTip { get; set; }
		bool HeaderFocus { get; set; }
	}
	public enum EditorType
	{
		Default,
		TwoStateCheckBox,
		ThreeStateCheckBox,
		ComboBox,
		Image
	}

	public enum ListColumnSortOrder
	{
		Unsorted = 0,
		Ascending = 1,
		Descending = 2,
		SecondaryAscending = 3,
		SecondaryDescending = 4
	}
}
