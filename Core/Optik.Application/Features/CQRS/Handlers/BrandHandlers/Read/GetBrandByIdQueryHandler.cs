using MediatR;
using Optik.Application.Features.CQRS.Queries.BrandQueries;
using Optik.Application.Features.CQRS.Results.BannerResults;
using Optik.Application.Features.CQRS.Results.BrandResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BrandHandlers.Read;

public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
{
    private readonly IRepository<Brand> _repository;

    public GetBrandByIdQueryHandler( IRepository<Brand> repository)
    {
         _repository = repository;
    }
    public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetBrandByIdQueryResult()
        {
            Id = value.Id,
            Name = value.Name,

        };
    }
}