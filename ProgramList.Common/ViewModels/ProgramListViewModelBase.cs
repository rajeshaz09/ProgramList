using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Data;

namespace ProgramList.Common.ViewModels
{
    public class ProgramListViewModelBase: ModelBase
    {
        public string TypeName = "Jeeves.CustomModels.MyType";
        public RadObservableCollection<IColumnInfo> Columns { get; private set; }

        public RadObservableCollection<ListItemBase> GridData { get; private set; }

        public ProgramListViewModelBase()
        {
            Columns = new RadObservableCollection<IColumnInfo>();
            GridData = new RadObservableCollection<ListItemBase>();
        }
        
    }
}
