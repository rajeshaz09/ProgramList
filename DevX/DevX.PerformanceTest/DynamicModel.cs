using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace DevX.PerformanceTest
{
    public class DynamicModel: DynamicObject, INotifyPropertyChanged
    {
        private Item _item = new Item();
        private ModelBase _modelBase = new ModelBase();

        string[] _properties = new string[] 
        {
            "Id", 
            "Active",
            "Prop01",
            "Prop02",
            "Prop03",
            "Prop04",
            "Prop05",
            "Prop06",
            "Prop07",
            "Prop08",
        };

        public DynamicModel(Item item)
        {
            _item = item;
        }
        public event PropertyChangedEventHandler PropertyChanged
        {
            add { _modelBase.PropertyChanged += value; }
            remove { _modelBase.PropertyChanged -= value; }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            switch (binder.Name)
            {
                case "Id":
                    result = _item.Id;
                    break;
                case "Active":
                    result = _item.Active;
                    break;
                case "Prop01":
                    result = _item.Prop01;
                    break;
                case "Prop02":
                    result = _item.Prop02;
                    break;
                case "Prop03":
                    result = _item.Prop03;
                    break;
                case "Prop04":
                    result = _item.Prop04;
                    break;
                case "Prop05":
                    result = _item.Prop05;
                    break;
                case "Prop06":
                    result = _item.Prop06;
                    break;
                case "Prop07":
                    result = _item.Prop07;
                    break;
                case "Prop08":
                    result = _item.Prop08;
                    break;
                default:
                    result = null;
                    break;
            }
            
            
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            switch (binder.Name)
            {
                case "Id":
                    _item.Id = (int)value;
                    break;
                case "Active":
                    _item.Active = (bool)value;
                    break;
                case "Prop01":
                    _item.Prop01 = (string)value;
                    break;
                case "Prop02":
                    _item.Prop02 = (string)value;
                    break;
                case "Prop03":
                    _item.Prop03 = (string)value;
                    break;
                case "Prop04":
                    _item.Prop04 = (string)value;
                    break;
                case "Prop05":
                    _item.Prop05 = (string)value;
                    break;
                case "Prop06":
                    _item.Prop06 = (string)value;
                    break;
                case "Prop07":
                    _item.Prop07 = (string)value;
                    break;
                case "Prop08":
                    _item.Prop08 = (string)value;
                    break;
                default:
                    break;
            }
            return true;
        }
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _properties;
        }
    }
}
