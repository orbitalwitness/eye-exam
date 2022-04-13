using EyeExamApi.DTOs;

namespace EyeExamApi.Interfaces
{
    public interface IRawScheduleDataService
    {
        IEnumerable<RawScheduleNoticeOfLease> GetRawScheduleNoticeOfLeases();
    }
}