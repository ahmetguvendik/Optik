using MediatR;
using Optik.Application.Features.CQRS.Queries.BrandQueries;
using Optik.Application.Features.CQRS.Results.BrandResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BrandHandlers.Read;

public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
{
    private readonly IRepository<Brand> _repository;

    public GetBrandQueryHandler( IRepository<Brand> repository )
    {
             _repository = repository;
    }
    public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAllAsync();
        return value.Select(x => new GetBrandQueryResult
        {
            Id = x.Id,
            Name = x.Name,
        }).ToList();
    }
}
