using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.POC.Models
{
    public class DynamicModel : DynamicBaseModel
    {
        private int _myInt;
        public int MyInt
        {
            get
            {
                return _myInt;
            }
            set
            {
                SetProperty(ref _myInt, value);
            }

        }
        private IList<CellInfo> _cellInfoList;
        public override object this[string property]
        {

            get
            {
                if (property.IndexOf('_') >= 0)
                {
                    var styleProperty = property.Substring(property.IndexOf('_'));
                    if (IsCellStylingProperty(styleProperty))
                    {
                        var columnNmae = property.Substring(0, property.IndexOf('_'));
                        var cellInfo = _cellInfoList.FirstOrDefault((info) => info.ColumnName == columnNmae);

                        return cellInfo?.GetType().GetProperty(styleProperty).GetValue(cellInfo);
                    }
                }
                return base[property];
            }
            set
            {
                if (property.IndexOf('_') >= 0)
                {
                    var styleProperty = property.Substring(property.IndexOf('_'));
                    if (IsCellStylingProperty(styleProperty))
                    {
                        var columnNmae = property.Substring(0, property.IndexOf('_'));
                        var cellInfo = _cellInfoList.FirstOrDefault((info) => info.ColumnName == columnNmae);

                        cellInfo?.GetType().GetProperty(styleProperty).SetValue(cellInfo, value);
                        return;
                    }
                }
                base[property] = value;
            }
        }

        private bool IsCellStylingProperty(string styleProperty)
        {
            return CellInfo.CustomisationProperties
                .Where(property => property == styleProperty)
                .Any();
        }
    }
}
