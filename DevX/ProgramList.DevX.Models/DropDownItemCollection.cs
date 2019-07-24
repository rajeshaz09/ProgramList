using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProgramList.DevX.Models
{
	public class DropDownItemCollection : ObservableCollection<DropDownItem>
	{
		public DropDownItemCollection()
		{
		}

		public DropDownItemCollection(IEnumerable<DropDownItem> items):base(items)
		{
		}
	}

	public class DropDownItem : BaseModel
	{
		private string _id;
		private string _name;

		public string Id
		{
			get
			{
				return _id;
			}
			set
			{
				SetProperty(ref _id, value);
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				SetProperty(ref _name, value);
			}
		}

		public DropDownItem(string id, string name)
		{
			_id = id;
			_name = name;
		}
	}
}
