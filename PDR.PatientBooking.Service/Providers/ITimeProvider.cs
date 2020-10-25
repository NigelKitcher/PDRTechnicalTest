using System;

namespace PDR.PatientBooking.Service.Providers
{
    public interface ITimeProvider
    {
        DateTime UtcNow { get; }
    }
}
