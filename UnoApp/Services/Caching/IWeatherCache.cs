using System.Collections.Immutable;
using UnoApp.DataContracts;

namespace UnoApp.Services.Caching
{
    public interface IWeatherCache
    {
        ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
    }
}