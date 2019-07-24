using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProgramList.DevX.Models
{ 
		public interface IListItemBase: IListCustomisation, ICustomTypeDescriptor, INotifyPropertyChanged
	{
		int RowNumber { get; set; }

		string GetBackground(string propertyName);
		void SetBackground(string background, string propertyName);

		string GetForeground(string propertyName);
		void SetForeground(string foreground, string propertyName);

		bool GetIsCurrent(string propertyName);
		void SetIsCurrent(bool isCurrent, string propertyName);

		bool GetIsEnabled(string propertyName);
		void SetIsEnabled(bool isCurrent, string propertyName);

		bool GetIsInEditMode(string propertyName);
		void SetIsInEditMode(bool isCurrent, string propertyName);

		bool GetIsReadOnly(string propertyName);
		void SetIsReadOnly(bool isCurrent, string propertyName);

		object GetData([CallerMemberName]string propertyName = "");
		void SetData<T>(T value, [CallerMemberName]string propertyName = "");
	}
}