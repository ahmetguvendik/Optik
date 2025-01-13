using MediatR;
using Optik.Application.Features.CQRS.Queries.ShopQueries;
using Optik.Application.Features.CQRS.Results.ShopResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ShopHandlers.Read;

public class GetShopByIdQueryHandler : IRequestHandler<GetShopByIdQuery, GetShopByIdQueryResult>
{
    private readonly IRepository<Shop> _repository;

    public GetShopByIdQueryHandler( IRepository<Shop> repository )
    {
        _repository = repository;  
    }
    public async Task<GetShopByIdQueryResult> Handle(GetShopByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetShopByIdQueryResult()
        {
            Id = value.Id,
            ImageURL = value.ImageURL,
            Title = value.Title,
            Description = value.Description,
        };
    }
}