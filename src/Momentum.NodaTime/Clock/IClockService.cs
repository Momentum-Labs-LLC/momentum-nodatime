using NodaTime;

namespace Momentum.NodaTime.Clock
{
    public interface IClockService
    {
        Instant Now { get; }
    } // end interface
} // end namespace