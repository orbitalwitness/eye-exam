namespace EyeExamApi.DTOs
{
    public class ParsedScheduleNoticeOfLease
    {
        /// <summary>
        /// The Entry Number
        /// </summary>
        public int EntryNumber { get; set; }

        /// <summary>
        /// Date the Entry was added
        /// </summary>
        public DateOnly? EntryDate { get; set; }

        /// <summary>
        /// Date the Entry registers and where it referred to on the Title Plan
        /// </summary>    
        public string RegistrationDateAndPlanRef { get; set; } = string.Empty;

        /// <summary>
        /// A brief description of the property
        /// </summary>
        public string PropertyDescription { get; set; } = string.Empty;

        /// <summary>
        /// Date the Lease was created from and how long it will live for.
        /// </summary>
        public string DateOfLeaseAndTerm { get; set; } = string.Empty;

        /// <summary>
        /// Title number of the Lessee
        /// </summary>
        public string LesseesTitle { get; set; } = string.Empty;

        /// <summary>
        /// All appended Notes to the Entry.
        /// </summary>
        public List<string> Notes { get; set; } = new List<string>();
    }
}