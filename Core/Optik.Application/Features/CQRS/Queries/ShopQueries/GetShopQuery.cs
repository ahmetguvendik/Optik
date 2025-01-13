using MediatR;
using Optik.Application.Features.CQRS.Results.ShopResults;

namespace Optik.Application.Features.CQRS.Queries.ShopQueries;

public class GetShopQuery : IRequest<List<GetShopQueryResult>>
{
    
}