using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.Models
{
    public interface IColumnInfo
    {
        string UniqueName { get; set; }
        Type DataType { get; }
    }
}
