using MediatR;
using Optik.Application.Features.CQRS.Queries.GlassQueries;
using Optik.Application.Features.CQRS.Results.GlassResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassHandlers.Read;

public class GetGlassQueryHandler : IRequestHandler<GetGlassQuery,List<GetGlassQueryResult>>
{
    private readonly IRepository<Glass> _repository;

    public GetGlassQueryHandler( IRepository<Glass> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetGlassQueryResult>> Handle(GetGlassQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetGlassQueryResult
        {
            Id = x.Id,
            Category = x.Category,  
            Material = x.Material,

        }).ToList();
    }
}