namespace EyeExamApi.DTOs
{
    public class RawScheduleNoticeOfLease
    {
        /// <summary>
        /// Entry Number of Entry
        /// </summary>
        public string EntryNumber { get; set; } = string.Empty;

        /// <summary>
        /// Date the Entry was added
        /// </summary>
        public string EntryDate { get; set; } = string.Empty;

        /// <summary>
        /// Type of the Entry
        /// </summary>
        public string EntryType { get; set; } = string.Empty;

        /// <summary>
        /// Details of the Entry
        /// </summary>
        public List<string> EntryText { get; set; } = new List<string>();
    }
}