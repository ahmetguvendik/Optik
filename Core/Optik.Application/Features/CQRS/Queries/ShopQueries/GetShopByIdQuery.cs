using MediatR;
using Optik.Application.Features.CQRS.Results.ShopResults;

namespace Optik.Application.Features.CQRS.Queries.ShopQueries;

public class GetShopByIdQuery : IRequest<GetShopByIdQueryResult>
{
    public string Id { get; set; }

    public GetShopByIdQuery(string id)
    {
         Id = id;
    }
    
}