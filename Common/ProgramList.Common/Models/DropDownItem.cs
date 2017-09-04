using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.Models
{
    public class DropDownItem: ModelBase
    {
        public const string IdProperty = nameof(Id);
        public const string NameProperty = nameof(Name);
        public DropDownItem(string id, string value)
        {
            _id = id;
            _name = value;
        }

        private string _id;
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
        private string _name;
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
    }
}
