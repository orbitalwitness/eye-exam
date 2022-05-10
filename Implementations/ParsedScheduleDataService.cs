using EyeExamApi.DTOs;
using EyeExamApi.Interfaces;

namespace EyeExamApi.Implementations
{
    public class ParsedScheduleDataService : IParsedScheduleDataService
    {
        public IEnumerable<ParsedScheduleNoticeOfLease> GetParsedScheduleNoticeOfLeases()
        {
            return new List<ParsedScheduleNoticeOfLease>()
        {
            new ParsedScheduleNoticeOfLease()
            {
                EntryNumber = 1,
                EntryDate = null,
                RegistrationDateAndPlanRef = "09.07.2009 Edged and numbered 2 in blue (part of)",
                PropertyDescription = "Endeavour House, 47 Cuba Street, London",
                DateOfLeaseAndTerm = "06.07.2009 125 years from 1.1.2009",
                LesseesTitle = "EGL557357"
            },
            new ParsedScheduleNoticeOfLease()
            {
                EntryNumber = 2,
                EntryDate = null,
                RegistrationDateAndPlanRef = "15.11.2018 Edged and numbered 2 in blue (part of)",
                PropertyDescription = "Ground Floor Premises",
                DateOfLeaseAndTerm = "10.10.2018 from 10 October 2018 to and including 19 April 2028",
                LesseesTitle = "TGL513556"
            },
            new ParsedScheduleNoticeOfLease()
            {
                EntryNumber = 3,
                EntryDate = null,
                RegistrationDateAndPlanRef = "16.08.2013",
                PropertyDescription = "21 Sheen Road (Ground floor shop)",
                DateOfLeaseAndTerm = "06.08.2013 Beginning on and including 6.8.2013 and ending on and including 6.8.2023",
                LesseesTitle = "TGL383606"
            },
            new ParsedScheduleNoticeOfLease()
            {
                EntryNumber = 4,
                EntryDate = null,
                RegistrationDateAndPlanRef = "24.07.1989 Edged and numbered 19 (Part of) in brown",
                PropertyDescription = "17 Ashworth Close (Ground and First Floor Flat)",
                DateOfLeaseAndTerm = "01.06.1989 125 years from 1.6.1989",
                LesseesTitle = "TGL24029",
                Notes = new List<string>() {
                    "NOTE 1: A Deed of Rectification dated 7 September 1992 made between (1) Orbit Housing Association and (2) John Joseph McMahon Nellie Helen McMahon and John George McMahon is supplemental to the Lease dated 1 June 1989 of 17 Ashworth Close referred to above. The lease actually comprises the second floor flat numbered 24 (Part of) on the filed plan. (Copy Deed filed under TGL24029)",
                    "NOTE 2: By a Deed dated 23 May 1996 made between (1) Orbit Housing Association (2) John Joseph McMahon Nellie Helen McMahon and John George McMahon and (3) Britannia Building Society the terms of the lease were varied. (Copy Deed filed under TGL24029).",
                    "NOTE 3: A Deed dated 13 February 1997 made between (1) Orbit Housing Association (2) John Joseph McMahon and others and (3) Britannia Building Society is supplemental to the lease. It substitutes a new plan for the original lease plan. (Copy Deed filed under TGL24029)"
                }
            },
            new ParsedScheduleNoticeOfLease()
            {
                EntryNumber = 5,
                EntryDate = null,
                RegistrationDateAndPlanRef = "19.09.1989 Edged and numbered 25 (Part of) in brown",
                PropertyDescription = "12 Harbord Close (Ground and First Floor Flat)",
                DateOfLeaseAndTerm = "01.09.1989 125 years from 1.9.1989",
                LesseesTitle = "TGL27196",
                Notes = new List<string>() {
                    "NOTE: By a Deed dated 20 July 1995 made between (1) Orbit Housing Association and (2) Clifford Ronald Mitchell the terms of the Lease were varied.  (Copy Deed filed under TGL27169)"
                }
            }
        };
        }
    }
}