using System;

namespace OA1.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
