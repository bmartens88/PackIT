using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Temperature;

internal sealed class HighTemperaturePolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
    {
        return data.Temperature > 25D;
    }

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>
        {
            new("Hat", 1),
            new("Sunglasses", 1),
            new("Cream with UV filter", 1)
        };
    }
}