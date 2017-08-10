namespace ProgramList.TelerikPOC.Models
{
    public interface ICustomisation
    {
        string Background { get; set; }
        string Foreground { get; set; }
        bool IsEnabled { get; set; }
        bool IsInEditMode { get; set; }
        bool IsReadOnly { get; set; }
        bool IsCurrent { get; set; }
    }
}