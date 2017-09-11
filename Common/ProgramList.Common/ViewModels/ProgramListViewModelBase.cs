using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProgramList.Common.ViewModels
{
    public class ProgramListViewModelBase: ModelBase
    {
        public string TypeName = "Jeeves.CustomModels.MyType";
        public IList<IColumnInfo> Columns { get; private set; }
        public IDictionary<string, ICommand> Commands { get; private set; }

        public ProgramListViewModelBase()
        {
            Columns = new ObservableCollection<IColumnInfo>();
            Commands = new Dictionary<string, ICommand>();

        }

    }
}
