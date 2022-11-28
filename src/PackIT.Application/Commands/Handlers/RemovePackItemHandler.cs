using PackIT.Application.Exceptions;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handlers;

public sealed class RemovePackItemHandler : ICommandHandler<RemovePackingItem>
{
    private readonly IPackingListRepository _repository;

    public RemovePackItemHandler(IPackingListRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(RemovePackingItem command)
    {
        var packingList = await _repository.GetAsync(command.PackingItemId);

        if (packingList is null) throw new PackingListNotFoundException(command.PackingItemId);

        packingList.RemoveItem(command.Name);

        await _repository.UpdateAsync(packingList);
    }
}