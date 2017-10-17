using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.POC.Models
{
    public abstract class DynamicBaseModel : DynamicObject, INotifyPropertyChanged
    {
        protected readonly IDictionary<string, object> data;

        public DynamicBaseModel()
        {
            data = new Dictionary<string, object>();
        }
        public DynamicBaseModel(IDictionary<string, object> source)
        {
            data = source;
        }

        #region DynamicObject
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return data.Keys;
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var property = GetType()
                       .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                       .Where((prop) => prop.Name == binder.Name).FirstOrDefault();

            if (property != null)
            {
                result = property.GetValue(this);
            }
            else
            {
                result = this[binder.Name];
            }

            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            var property = GetType()
            .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
            .Where((prop) => prop.Name == binder.Name).FirstOrDefault();

            if (property != null)
            {
                property.SetValue(this, value);
            }
            else
                this[binder.Name] = value;

            return true;
        }

        #endregion DynamicObject


        public virtual object this[string columnName]
        {
            get
            {
                if (data.ContainsKey(columnName))
                {
                    return data[columnName];
                }

                return null;
            }
            set
            {
                if (!data.ContainsKey(columnName))
                {
                    data.Add(columnName, value);

                    OnPropertyChanged(columnName);
                }
                else
                {
                    if (data[columnName] != value)
                    {
                        data[columnName] = value;

                        OnPropertyChanged(columnName);
                    }
                }
            }
        }
        #region INotifyPropertyChanged 
        private readonly ModelBase _baseModel = new ModelBase();

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                _baseModel.PropertyChanged += value;
            }
            remove
            {
                _baseModel.PropertyChanged -= value;
            }
        }

        protected void OnPropertyChanged([CallerMemberName]string name = "")
        {
            _baseModel.OnPropertyChanged(name);
        }

        public void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            _baseModel.SetProperty(ref storage, value, propertyName);
        }

        #endregion INotifyPropertyChanged
    }
}
