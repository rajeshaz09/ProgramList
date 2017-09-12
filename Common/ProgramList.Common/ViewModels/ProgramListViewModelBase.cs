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
    public class ProgramListViewModelBase : ModelBase
    {
        public readonly string TypeName;
        public IList<IColumnInfo> Columns { get; private set; }
        public IDictionary<string, ICommand> Commands { get; private set; }

        private static int TypeSeed = 0;
        public int Seed = 0;
        public int Rows { get; private set; }
        public int ColumnSets { get; private set; }


        public ProgramListViewModelBase(int rows, int columnSets)
        {
            Rows = rows;
            ColumnSets = columnSets;
            TypeName = $"Jeeves.CustomModels.MyType{TypeSeed++}";
            Columns = new ObservableCollection<IColumnInfo>();
            Commands = new Dictionary<string, ICommand>();

        }
    }
}
