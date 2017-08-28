using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using WpfApplication1.Dynamic;

namespace ScrollIntoViewAsyncMvvm
{
    public class Club : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

        private Dictionary<string, object> _propertyValues = new Dictionary<string, object>();


        public T GetValue<T>([CallerMemberName]string propertyName = "")
        {
            if (_propertyValues.ContainsKey(propertyName))
                return ((CustomProperty<T>)_propertyValues[propertyName]).Value;

            var property = new CustomProperty<T>(default(T));
            _propertyValues.Add(propertyName, property);

            return property.Value;

        }

        public void SetValue<T>(T value, [CallerMemberName]string propertyName = "")
        {
            _propertyValues[propertyName] = new CustomProperty<T>(value);
            OnPropertyChanged(propertyName);
        }


        public Club(string name, DateTime? established, int stadiumCapacity)
        {
            this.Name00 = name;
            this.Name01 = name;
            this.Name02 = name;
            this.Name03 = name;
            this.Name04 = name;
            this.Name05 = name;
            this.Name06 = name;
            this.Name07 = name;
            this.Name08 = name;
            this.Name09 = name;
            this.Name10 = name;
            this.Name11 = name;
            this.Name12 = name;
            this.Name13 = name;
            this.Name14 = name;
            this.Name15 = name;
            this.Name16 = name;
            this.Name17 = name;
            this.Name18 = name;
            this.Name19 = name;
            this.Established00 = established;
            this.Established01 = established;
            this.Established02 = established;
            this.Established03 = established;
            this.Established04 = established;
            this.Established05 = established;
            this.Established06 = established;
            this.Established07 = established;
            this.Established08 = established;
            this.Established09 = established;
            this.Established10 = established;
            this.Established11 = established;
            this.Established12 = established;
            this.Established13 = established;
            this.Established14 = established;
            this.Established15 = established;
            this.Established16 = established;
            this.Established17 = established;
            this.Established18 = established;
            this.Established19 = established;
            this.StadiumCapacity00 = stadiumCapacity;
        }


        public string Name00
		{
			get
            {
                return GetValue<string>();
            }
			set
			{
                SetValue(value);
			}
		}
        

        public string Name01
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name02
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name03
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name04
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name05
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name06
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name07
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name08
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name09
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name10
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name11
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name12
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name13
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name14
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name15
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name16
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name17
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public string Name18
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }
        public string Name19
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }


        public DateTime? Established00
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established01
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established02
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established03
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established04
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }
        

        public DateTime? Established05
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established06
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established07
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established08
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established09
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established10
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established11
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established12
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established13
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established14
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established15
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established16
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established17
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established18
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public DateTime? Established19
        {

            get
            {
                return GetValue<DateTime?>();
            }
            set
            {
                SetValue(value);
            }
        }

        public int StadiumCapacity00
		{

            get
            {
                return GetValue<int>();
            }
            set
            {
                SetValue(value);
            }
        }
        
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
		{
            this.PropertyChanged?.Invoke(this, args);
        }

		private void OnPropertyChanged(string propertyName)
		{
			this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}

		public override string ToString()
		{
			return this.Name00;
		}

		
	}
}
