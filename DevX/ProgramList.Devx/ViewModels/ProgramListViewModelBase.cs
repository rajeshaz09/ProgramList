using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.ViewModels
{
    public class ProgramListViewModelBase: ModelBase
    {
        public string TypeName = "Jeeves.CustomModels.MyType";
        public RangeObservableCollection<IColumnInfo> Columns { get; private set; }

        public RangeObservableCollection<ListItemBase> GridData { get; private set; }

        public ProgramListViewModelBase()
        {
            Columns = new RangeObservableCollection<IColumnInfo>();
            GridData = new RangeObservableCollection<ListItemBase>();
        }
        
    }
}
