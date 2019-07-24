using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;
using DevExpress.Mvvm;
using DevExpress.Utils;
using System.IO;
using System.Windows.Threading;
using ProgramList.DevX.Models;

namespace ProgramList.DevX.ViewModels
{
	public class ProgramListViewModel : BaseModel, IProgramListViewModel
	{
		private PropertyDescriptorCollection _propertyDescriptors;

		public ObservableCollectionCore<IColumnInfo> Columns { get; set; }
        public DynamicModelCollection<DynamicModel>  GridData { get; set; }
        public Dictionary<string, DropDownItemCollection> ComboBoxDictionary { get; set; }

		public ProgramListViewModel()
		{
			Columns = new ObservableCollectionCore<IColumnInfo>();
			GridData = new DynamicModelCollection<DynamicModel>();
            ComboBoxDictionary= new Dictionary<string, DropDownItemCollection>(); ;
        }

        public void UpdateDescriptors(IList<IColumnInfo> columns)
        {
            var descriptors = new List<PropertyDescriptor>(columns.Count);
            foreach (var column in columns)
                descriptors.Add(new CellInfoDescriptor(column.UniqueId.ToString()));
            _propertyDescriptors?.Clear();
            _propertyDescriptors = new PropertyDescriptorCollection(descriptors.ToArray());

            GridData.UpdateDescriptors(_propertyDescriptors);
        }

        public void Dispose()
		{
		}
	}

}

