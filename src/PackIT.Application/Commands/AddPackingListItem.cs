using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands;

public record AddPackingListItem(
    Guid PackingListId,
    string Name,
    uint Quantity) : ICommand;