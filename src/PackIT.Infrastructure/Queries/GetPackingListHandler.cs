using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries;

public sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
{
    public Task<PackingListDto> HandleAsync(GetPackingList query)
    {
        throw new NotImplementedException();
    }
}