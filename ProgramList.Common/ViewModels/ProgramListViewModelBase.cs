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
        public ObservableCollection<IColumnInfo> Columns { get; private set; }

        public ObservableCollection<ListItemBase> GridData { get; private set; }

        public ProgramListViewModelBase()
        {
            Columns = new ObservableCollection<IColumnInfo>();
            GridData = new ObservableCollection<ListItemBase>();
        }
        
    }
}
