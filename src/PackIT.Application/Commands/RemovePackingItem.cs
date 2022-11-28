using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands;

public record RemovePackingItem(
    Guid PackingItemId,
    string Name) : ICommand;