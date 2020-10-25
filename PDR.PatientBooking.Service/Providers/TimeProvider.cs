using System;

namespace PDR.PatientBooking.Service.Providers
{
    public class TimeProvider : ITimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
