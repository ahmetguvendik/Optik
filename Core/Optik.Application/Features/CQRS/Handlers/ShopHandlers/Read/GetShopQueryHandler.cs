using MediatR;
using Optik.Application.Features.CQRS.Queries.ShopQueries;
using Optik.Application.Features.CQRS.Results.ShopResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ShopHandlers.Read;

public class GetShopQueryHandler : IRequestHandler<GetShopQuery, List<GetShopQueryResult>>
{
    private readonly IRepository<Shop> _repository;

    public GetShopQueryHandler( IRepository<Shop> repository )
    {
        _repository = repository;  
    }
    public async Task<List<GetShopQueryResult>> Handle(GetShopQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetShopQueryResult
        {
            Id = x.Id,
            ImageURL = x.ImageURL,
            Description = x.Description,
            Title = x.Title,

        }).ToList();
    }
}