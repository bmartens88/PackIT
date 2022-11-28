using PackIT.Application.DTO;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries;

public sealed class SearchPackingLists : IQuery<IEnumerable<PackingListDto>>
{
    public string SearchPhrase { get; set; }
}