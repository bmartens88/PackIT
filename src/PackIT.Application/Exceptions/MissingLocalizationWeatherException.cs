using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Application.Exceptions;

public sealed class MissingLocalizationWeatherException : PackItException
{
    public Localization Localization { get; }

    public MissingLocalizationWeatherException(Localization localization)
        : base($"Couldn't fetch weather for localization '{localization.Country}/{localization.City}'")
    {
        Localization = localization;
    }
}