using Microsoft.Extensions.DependencyInjection;
using Momentum.Analytics.Core;
using Momentum.NodaTime.Clock;
using NodaTime;
using NodaTime.TimeZones;

namespace Momentum.NodaTime
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNodaTime(this IServiceCollection services)
        {
            return services
                .AddSingleton<IDateTimeZoneSource>(TzdbDateTimeZoneSource.Default)
                .AddSingleton<IDateTimeZoneProvider, DateTimeZoneCache>()
                .AddSingleton<IClock>(SystemClock.Instance)
                .AddSingleton<IClockService, ClockService>();
        } // end method
    } // end class
} // end namespace