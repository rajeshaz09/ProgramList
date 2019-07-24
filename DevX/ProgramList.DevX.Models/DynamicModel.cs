
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.DevX.Models
{
	public class DynamicModel : DynamicObject, IListItemBase, IDisposable
	{
		private IList<IColumnInfo> _columns;
		private PropertyDescriptorCollection _propertyDescriptors;
		private bool _disposed;
		private ModelDataDictionary _propertyValues;
		public ModelDataDictionary PropertyValues { get { return _propertyValues; } }

		public DynamicModel(PropertyDescriptorCollection propertyDescriptors,
			IList<IColumnInfo> columns, int rowNumber)
		{
			_propertyDescriptors = propertyDescriptors;
			_columns = columns;
			RowNumber = rowNumber;
			_propertyValues = new ModelDataDictionary(_columns.Count);

			foreach (var column in _columns)
			{
				PropertyValues.Add(column.UniqueId.ToString(), new CellInfo(column, this));
			}
			State = RowState.NotRequested;
		}

		public DynamicModel(PropertyDescriptorCollection propertyDescriptors,
			IList<IColumnInfo> columns, int rowNumber, RowState state) : this(propertyDescriptors, columns, rowNumber)
		{
			State = state;
		}

		public void SetData<T>(T value, [CallerMemberName]string propertyName = "")
		{
			if (PropertyValues[propertyName].Data?.ToString() != value?.ToString())
			{
				PropertyValues[propertyName].Data = value;
				OnPropertyChanged(propertyName);
			}
		}
		public object GetData([CallerMemberName]string propertyName = "")
		{
			return PropertyValues[propertyName].Data;
		}

		private RowState _state;
		public RowState State
		{
			get
			{
				return _state;
			}
			set
			{
				SetProperty(ref _state, value);
			}
		}

		private SelectionState _selectionState;
		public SelectionState SelectionState
		{
			get
			{
				return _selectionState;
			}
			set
			{
				SetProperty(ref _selectionState, value);
			}
		}

		private int _rowNumber = -1;
		public int RowNumber
		{
			get
			{
				return _rowNumber;
			}
			set
			{
				SetProperty(ref _rowNumber, value);
			}
		}

		private string _background;
		public string Background
		{
			get
			{
				return _background;
			}
			set
			{
				SetProperty(ref _background, value);
			}
		}

		private string _foreground;
		public string Foreground
		{
			get
			{
				return _foreground;
			}
			set
			{
				SetProperty(ref _foreground, value);
			}
		}

		private bool _isEnabled;
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

		private bool _isReadOnly = false;
		public bool IsReadOnly
		{
			get
			{
				return _isReadOnly;
			}
			set
			{
				SetProperty(ref _isReadOnly, value);
			}
		}

		private bool _isInEditMode;
		public bool IsInEditMode
		{
			get
			{
				return _isInEditMode;
			}
			set
			{
				SetProperty(ref _isInEditMode, value);
			}
		}

		private bool _isCurrent;
		public bool IsCurrent
		{
			get
			{
				return _isCurrent;
			}
			set
			{
				SetProperty(ref _isCurrent, value);
			}
		}

		public string GetForeground(string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
				return PropertyValues[propertyName].Foreground;

			return null;
		}

		public void SetForeground(string foreground, string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
			{
				var cellProperties = PropertyValues[propertyName];
				if (cellProperties.Foreground == foreground)
					return;
				PropertyValues[propertyName].Foreground = foreground;
				return;
			}
			return;
		}

		public string GetBackground(string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
				return PropertyValues[propertyName].Background;

			return null;
		}

		public void SetBackground(string background, string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
			{
				var cellProperties = PropertyValues[propertyName];
				if (cellProperties.Background == background)
					return;
				PropertyValues[propertyName].Background = background;
				return;
			}
			return;

		}

		public bool GetIsEnabled(string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
				return PropertyValues[propertyName].IsEnabled;

			return true;
		}

		public void SetIsEnabled(bool isEnabled, string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
			{
				var cellProperties = PropertyValues[propertyName];
				if (cellProperties.IsEnabled == isEnabled)
					return;
				PropertyValues[propertyName].IsEnabled = isEnabled;
				return;
			}
			return;
		}

		public bool GetIsReadOnly(string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
				return PropertyValues[propertyName].IsReadOnly;

			return true;
		}

		public void SetIsReadOnly(bool isReadOnly, string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
			{
				var cellProperties = PropertyValues[propertyName];
				if (cellProperties.IsReadOnly == isReadOnly)
					return;
				PropertyValues[propertyName].IsReadOnly = isReadOnly;
				return;
			}
			return;

		}

		public bool GetIsInEditMode(string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
				return PropertyValues[propertyName].IsInEditMode;

			return true;
		}

		public void SetIsInEditMode(bool isInEditMode, string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
			{
				var cellProperties = PropertyValues[propertyName];
				if (cellProperties.IsInEditMode == isInEditMode)
					return;
				PropertyValues[propertyName].IsInEditMode = isInEditMode;
				return;
			}
			return;
		}

		public bool GetIsCurrent(string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
				return PropertyValues[propertyName].IsCurrent;

			return true;
		}

		public void SetIsCurrent(bool isCurrent, string propertyName)
		{
			if (propertyName != null && PropertyValues.ContainsKey(propertyName))
			{
				var cellProperties = PropertyValues[propertyName];
				if (cellProperties.IsCurrent == isCurrent)
					return;
				PropertyValues[propertyName].IsCurrent = isCurrent;
				return;
			}
			return;

		}


		#region INotifyPropertyChanged 


		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public void OnPropertyChanged([CallerMemberName]string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
		{
			if (!EqualityComparer<T>.Default.Equals(storage, value))
			{
				storage = value;
				OnPropertyChanged(propertyName);
				return true;
			}
			return false;
		}

		#endregion INotifyPropertyChanged

		#region DynamicObject
		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			result = GetValue(binder.Name);

			return true;
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			SetValue(binder.Name, value as CellInfo);

			return true;
		}

		internal CellInfo GetValue(string columnName)
		{
			return PropertyValues[columnName];
		}

		internal void SetValue(string columnName, CellInfo cellInfo)
		{
			PropertyValues[columnName] = cellInfo;
		}

		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return PropertyValues.Keys;
		}

		#endregion DynamicObject


		#region ICustomTypeDescriptor
		public AttributeCollection GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		public string GetClassName()
		{
			return null;
		}

		public string GetComponentName()
		{
			return null;
		}

		public TypeConverter GetConverter()
		{
			return new TypeConverter();
		}

		public EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		public object GetEditor(Type editorBaseType)
		{
			return null;
		}

		public EventDescriptorCollection GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return GetEvents();
		}

		public PropertyDescriptorCollection GetProperties()
		{
			return _propertyDescriptors;
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return GetProperties();
		}

		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
		#endregion ICustomTypeDescriptor

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected void Dispose(bool disposing)
		{
			if (_disposed)
				return;

			if (disposing)
			{
				PropertyChanged = null;
				_columns?.Clear();
				_propertyDescriptors?.Clear();
				_propertyValues?.Clear();
				_columns = null;
				_propertyDescriptors = null;
				_propertyValues = null;
			}

			_disposed = true;
		}

	}

}
