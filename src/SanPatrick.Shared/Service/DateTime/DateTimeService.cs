using SanPatrick.Application.Interfaces;

namespace SanPatrick.Shared.Service.DateTime
{
    public class DateTimeService : IDateTimeService
    {
        public System.DateTime NowUTC => System.DateTime.UtcNow;
    }
}
