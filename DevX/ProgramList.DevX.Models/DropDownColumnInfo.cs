using System.Collections.Generic;



namespace ProgramList.DevX.Models
{
    public sealed class DropDownColumnInfo : DefaultColumnInfo
	{
		private DropDownItemCollection _itemsSource;
		public DropDownItemCollection ItemsSource { get => _itemsSource; }

		bool _isPopupOpen;
		public bool IsPopupOpen
		{
			get { return _isPopupOpen; }
			set { SetProperty(ref _isPopupOpen, value); }
		}

		public DropDownColumnInfo(string header, EditorType dataType, ListColumnAlignment columnAlignment, int uniqueId, string table, string windowContext,
			string field, int sequenceId, bool isVisible, bool isReadOnly,
			bool isEnabled, bool isSelected, bool isLinked, double width, Dictionary<string, DropDownItemCollection> itemsSource)
				: base(header, dataType, columnAlignment, uniqueId, table, windowContext, field, sequenceId, isVisible, isReadOnly, isEnabled, isSelected, isLinked, width)
		{
			if (itemsSource == null)
				return;
			if (itemsSource.ContainsKey(sequenceId.ToString()))
				_itemsSource = itemsSource[sequenceId.ToString()];
			else
				_itemsSource = new DropDownItemCollection();
		}
	}
}
