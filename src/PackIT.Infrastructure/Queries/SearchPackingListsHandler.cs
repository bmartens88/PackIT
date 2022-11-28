using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries;

public sealed class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
{
    public Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
    {
        throw new NotImplementedException();
    }
}