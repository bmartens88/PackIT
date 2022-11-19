using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender;

internal sealed class FemaleGenderPolicy : IPackingItemsPolicy
{
    public bool IsApplicable(PolicyData data)
    {
        return data.Gender is Consts.Gender.Female;
    }

    public IEnumerable<PackingItem> GenerateItems(PolicyData data)
    {
        return new List<PackingItem>
        {
            new("Lipstick", 1),
            new("Powder", 1),
            new("Eyeliner", 1)
        };
    }
}