using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.Models
{

    public class CellInfo : ModelBase, ICustomisation
    {
        public IColumnInfo Column { get; private set; }
        private ICustomisation _rowCustomisation;
        private bool _notifyChanges = true;

        internal static readonly string[] CustomisationProperties = new string[] {
            nameof(Background),
            nameof(Foreground),
            nameof(IsReadOnly) ,
            nameof(IsEnabled),
            nameof(IsInEditMode),
            nameof(IsCurrent)
        };

        private string _background;
        public string Background
        {
            get
            {
                return _background;
            }
            set
            {
                SetPropertyInternal(ref _background, value);
            }
        }

        private string _foreground;
        public string Foreground
        {
            get
            {
                return _foreground;
            }
            set
            {
                SetPropertyInternal(ref _foreground, value);
            }
        }

        private bool _isEnabled = true;
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }
            set
            {
                SetPropertyInternal(ref _isEnabled, value);
            }
        }

        private bool _isReadOnly;
        public bool IsReadOnly
        {
            get
            {
                return _isReadOnly;
            }
            set
            {
                SetPropertyInternal(ref _isReadOnly, value);
            }
        }

        private bool _isInEditMode;
        public bool IsInEditMode
        {
            get
            {
                return _isInEditMode;
            }
            set
            {
                SetPropertyInternal(ref _isInEditMode, value);
            }
        }

        private bool _isCurrent;
        public bool IsCurrent
        {
            get
            {
                return _isCurrent;
            }
            set
            {
                SetPropertyInternal(ref _isCurrent, value);
            }
        }

        

        public CellInfo(IColumnInfo column, ICustomisation rowCustomisation, bool notifyChanges = true)
        {
            Column = column;
            _rowCustomisation = rowCustomisation;
            _notifyChanges = notifyChanges;
        }



        private void SetPropertyInternal<T>(ref T property, T value)
        {
            if (_notifyChanges)
                SetProperty(ref property, value);
            else
                property = value;
        }

    }
}
