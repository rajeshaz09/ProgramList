using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;
using ProgramList.DevX.Models;

namespace ProgramList.DevX.Models
{
	public class DefaultColumnInfo : BaseModel, IColumnInfo
	{
		private bool _isSelected;
		private string _table;
		private string _field;
		private int _sequenceId;
		private bool _isLinkedProgram;
		private string _windowContext;
		private bool _bound;
		private int _uniqueId;
		private string _fieldName;
		private string _header;
		private bool _visible;
		private bool _readOnly;
		private bool _isEnabled;
		private double _minWidth;
		private DefaultBoolean _allowEditing;
		private bool _tabStop;
		private bool _allowFocus;
		private DefaultBoolean _allowGrouping;
		private DefaultBoolean _allowSorting;
		private double _width;
		private bool _autoWidth;
		private EditorType _editSettings;
		private int _groupIndex;
		private string _columnAlignment;
		private ColumnSortOrder _sortOrder;
		private ListColumnSortOrder _columnSortOrder;
		private object _searchText;
		private string _searchToolTip;
		private bool _headerFocus;

		public object SearchText
		{
			get
			{
				return _searchText;
			}
			set
			{
				SetProperty(ref _searchText, value);
			}
		}

		public bool HeaderFocus
		{
			get
			{
				return _headerFocus;
			}
			set
			{
				SetProperty(ref _headerFocus, value);
			}
		}

		public string SearchToolTip
		{
			get
			{
				return _searchToolTip;
			}
			set
			{
				SetProperty(ref _searchToolTip, value);
			}
		}

		public bool IsSelected
		{
			get
			{
				return _isSelected;
			}
			set
			{
				SetProperty(ref _isSelected, value);
			}
		}
		public string Table
		{
			get
			{
				return _table;
			}
			set
			{
				SetProperty(ref _table, value);
			}
		}
		public string Field
		{
			get
			{
				return _field;
			}
			set
			{
				SetProperty(ref _field, value);
			}
		}
		public int SequenceId
		{
			get
			{
				return _sequenceId;
			}
			set
			{
				SetProperty(ref _sequenceId, value);
			}
		}
		public bool IsLinkedProgram
		{
			get
			{
				return _isLinkedProgram;
			}
			set
			{
				SetProperty(ref _isLinkedProgram, value);
			}
		}
		public string WindowContext
		{
			get
			{
				return _windowContext;
			}
			set
			{
				SetProperty(ref _windowContext, value);
			}
		}
		public bool Bound
		{
			get
			{
				return _bound;
			}
			set
			{
				SetProperty(ref _bound, value);
			}
		}
		public int UniqueId
		{
			get
			{
				return _uniqueId;
			}
			set
			{
				SetProperty(ref _uniqueId, value);
			}
		}
		public string FieldName
		{
			get
			{
				return _fieldName;
			}
			set
			{
				SetProperty(ref _fieldName, value);
			}
		}
		public string ColumnName { get => _uniqueId.ToString(); }
		public string Header
		{
			get
			{
				return _header;
			}
			set
			{
				SetProperty(ref _header, value);
			}
		}
		public String ColumnAlignment
		{
			get
			{
				return _columnAlignment;
			}
			set
			{
				SetProperty(ref _columnAlignment, value);
			}
		}
		public bool Visible
		{
			get
			{
				return _visible;
			}
			set
			{
				SetProperty(ref _visible, value);
			}
		}
		public bool ReadOnly
		{
			get
			{
				return _readOnly;
			}
			set
			{
				SetProperty(ref _readOnly, value);
			}
		}
		public bool IsEnabled
		{
			get
			{
				return _isEnabled;
			}
			set
			{
				SetProperty(ref _isEnabled, value);
			}
		}
		public double MinWidth
		{
			get
			{
				return _minWidth;
			}
			set
			{
				SetProperty(ref _minWidth, value);
			}
		}
		public DefaultBoolean AllowEditing
		{
			get
			{
				return _allowEditing;
			}
			set
			{
				SetProperty(ref _allowEditing, value);
			}
		}
		public bool TabStop
		{
			get
			{
				return _tabStop;
			}
			set
			{
				SetProperty(ref _tabStop, value);
			}
		}
		public bool AllowFocus
		{
			get
			{
				return _allowFocus;
			}
			set
			{
				SetProperty(ref _allowFocus, value);
			}
		}
		public DefaultBoolean AllowGrouping
		{
			get
			{
				return _allowGrouping;
			}
			set
			{
				SetProperty(ref _allowGrouping, value);
			}
		}
		public DefaultBoolean AllowSorting
		{
			get
			{
				return _allowSorting;
			}
			set
			{
				SetProperty(ref _allowSorting, value);
			}
		}

		public ColumnSortOrder SortOrder
		{
			get
			{
				return _sortOrder;
			}
			set
			{
				SetProperty(ref _sortOrder, value);
			}
		}
		public double Width
		{
			get
			{
				return _width;
			}
			set
			{
				SetProperty(ref _width, value);
			}
		}

		public bool AutoWidth
		{
			get
			{
				return _autoWidth;
			}
			set
			{
				SetProperty(ref _autoWidth, value);
			}
		}
		public EditorType EditSettings
		{
			get
			{
				return _editSettings;
			}
			set
			{
				SetProperty(ref _editSettings, value);
			}
		}

		public int GroupIndex
		{
			get
			{
				return _groupIndex;
			}
			set
			{
				SetProperty(ref _groupIndex, value);
			}
		}

		public int ServerIndex { get; set; }
		public ListColumnSortOrder ColumnSortOrder
		{
			get
			{
				return _columnSortOrder;
			}
			set
			{
				SetProperty(ref _columnSortOrder, value);
			}
		}

		public DefaultColumnInfo(string header, EditorType dataType, ListColumnAlignment columnAlignment, int uniqueId, string table, string windowContext, string field, int sequenceId, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected, bool isLinked, double width)
		{
			EditSettings = dataType;
			ColumnAlignment = columnAlignment.ToString();
			Table = table;
			IsSelected = isSelected;
			IsLinkedProgram = isLinked;
			WindowContext = windowContext;
			Field = field;
			SequenceId = sequenceId;
			UniqueId = uniqueId;
			ServerIndex = uniqueId;
			FieldName = $"{uniqueId}.Data";

			Header = header;
			Visible = isVisible;
			ReadOnly = isReadOnly;
			IsEnabled = isEnabled;
			AllowEditing = (ReadOnly || !IsEnabled) ? DefaultBoolean.False : DefaultBoolean.Default;
			TabStop = true;
			AllowFocus = true;
			AllowGrouping = DefaultBoolean.True;
			AllowSorting = DefaultBoolean.True;

			MinWidth = MINIMUM_WIDTH;
			if (width >= 0)
				Width = width;
			else
				AutoWidth = true;
			GroupIndex = -1;
		}

		public override string ToString()
		{
			return Header;
		}

		#region Constants
		private const double MINIMUM_WIDTH = 50;
		#endregion

	}
}
