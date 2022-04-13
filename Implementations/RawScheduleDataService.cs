using EyeExamApi.DTOs;
using EyeExamApi.Interfaces;

namespace EyeExamApi.Implementations
{
    public class RawScheduleDataService : IRawScheduleDataService
    {
        private readonly Random _rng;

        public RawScheduleDataService()
        {
            _rng = new Random();
        }

        /// <summary>
        /// Returns a collection of example Raw Schedule data.
        /// ... in a semi random order ;).
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RawScheduleNoticeOfLease> GetRawScheduleNoticeOfLeases()
        {
            var results = new List<RawScheduleNoticeOfLease>()
        {
            new RawScheduleNoticeOfLease()
            {
                EntryNumber = "1",
                EntryDate = "",
                EntryType = "Schedule of Notices of Leases",
                EntryText = new List<string>() {
                    "09.07.2009      Endeavour House, 47 Cuba      06.07.2009      EGL557357  ",
                    "Edged and       Street, London                125 years from             ",
                    "numbered 2 in                                 1.1.2009                   ",
                    "blue (part of)"
                }
            },
            new RawScheduleNoticeOfLease()
            {
                EntryNumber = "2",
                EntryDate = "",
                EntryType = "Schedule of Notices of Leases",
                EntryText = new List<string>() {
                    "15.11.2018      Ground Floor Premises         10.10.2018      TGL513556  ",
                    "Edged and                                     from 10                    ",
                    "numbered 2 in                                 October 2018               ",
                    "blue (part of)                                to and                     ",
                    "including 19               ",
                    "April 2028"
                }
            },
            new RawScheduleNoticeOfLease()
            {
                EntryNumber = "3",
                EntryDate = "",
                EntryType = "Schedule of Notices of Leases",
                EntryText = new List<string>() {
                    "16.08.2013      21 Sheen Road (Ground floor   06.08.2013      TGL383606  ",
                    "shop)                         Beginning on               ",
                    "and including              ",
                    "6.8.2013 and               ",
                    "ending on and              ",
                    "including                  ",
                    "6.8.2023"
                }
            },
            new RawScheduleNoticeOfLease()
            {
                EntryNumber = "4",
                EntryDate = "",
                EntryType = "Schedule of Notices of Leases",
                EntryText = new List<string>() {
                   "24.07.1989      17 Ashworth Close (Ground     01.06.1989      TGL24029   ",
                    "Edged and       and First Floor Flat)         125 years from             ",
                    "numbered 19                                   1.6.1989                   ",
                    "(Part of) in                                                             ",
                    "brown                                                                    ",
                    "NOTE 1: A Deed of Rectification dated 7 September 1992 made between (1) Orbit Housing Association and (2) John Joseph McMahon Nellie Helen McMahon and John George McMahon is supplemental to the Lease dated 1 June 1989 of 17 Ashworth Close referred to above. The lease actually comprises the second floor flat numbered 24 (Part of) on the filed plan. (Copy Deed filed under TGL24029)",
                    "NOTE 2: By a Deed dated 23 May 1996 made between (1) Orbit Housing Association (2) John Joseph McMahon Nellie Helen McMahon and John George McMahon and (3) Britannia Building Society the terms of the lease were varied. (Copy Deed filed under TGL24029).",
                    "NOTE 3: A Deed dated 13 February 1997 made between (1) Orbit Housing Association (2) John Joseph McMahon and others and (3) Britannia Building Society is supplemental to the lease. It substitutes a new plan for the original lease plan. (Copy Deed filed under TGL24029)"
                }
            },
            new RawScheduleNoticeOfLease()
            {
                EntryNumber = "5",
                EntryDate = "",
                EntryType = "Schedule of Notices of Leases",
                EntryText = new List<string>() {
                    "19.09.1989      12 Harbord Close (Ground      01.09.1989      TGL27196   ",
                    "Edged and       and First Floor Flat)         125 years from             ",
                    "numbered 25                                   1.9.1989                   ",
                    "(Part of) in                                                             ",
                    "brown                                                                    ",
                    "NOTE: By a Deed dated 20 July 1995 made between (1) Orbit Housing Association and (2) Clifford Ronald Mitchell the terms of the Lease were varied.  (Copy Deed filed under TGL27169)"
                }
            }
        };

            return results.OrderBy(a => _rng.Next());
        }
    }
}