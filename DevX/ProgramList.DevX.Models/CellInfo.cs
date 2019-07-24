using ProgramList.DevX.Models;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.DevX.Models
{
	public class CellInfo : BaseModel, IListCustomisation
	{
		public IColumnInfo Column { get; }
		public IListItemBase Row { get; }

		private object _data;
		public object Data
		{
			get
			{
				return _data;
			}
			set
			{
				SetProperty(ref _data, value);
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

		private bool _isEnabled = true;
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

		private bool _isReadOnly;
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

		public CellInfo(IColumnInfo column, IListItemBase row)
		{
			Column = column;
			Row = row;
		}
	}
}
