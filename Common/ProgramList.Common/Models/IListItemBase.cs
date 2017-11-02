namespace ProgramList.Common.Models
{
    public interface IListItemBase
    {
        int RowNumber { get; }

        string GetBackground(string propertyName);
        string GetBackgroundInternal(string caller);
        string GetForeground(string propertyName);
        string GetForegroundInternal(string caller);
        bool GetIsCurrent(string propertyName);
        bool GetIsEnabled(string propertyName);
        bool GetIsInEditMode(string propertyName);
        bool GetIsReadOnly(string propertyName);
        void SetBackgroundInternal(string background, string caller);
        void SetForegroundInternal(string foreground, string caller);
        void SetIsCurrentInternal(bool isCurrent, string caller);
    }
}