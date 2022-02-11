using AddressBook2.Services.Interfaces;

namespace AddressBook2.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime dateTimeUtcToLocal(DateTime dt)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.Local);
        }
    }
}
