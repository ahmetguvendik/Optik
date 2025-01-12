using MediatR;
using Optik.Application.Features.CQRS.Queries.GlassQueries;
using Optik.Application.Features.CQRS.Results.GlassResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassHandlers.Read;

public class GetGlassByIdQueryHandler : IRequestHandler<GetGlassByIdQuery, GetGlassByIdQueryResult>
{
    private readonly IRepository<Glass> _repository;

    public GetGlassByIdQueryHandler( IRepository<Glass> repository)
    {
        _repository = repository;
    }
    public async Task<GetGlassByIdQueryResult> Handle(GetGlassByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        if (value == null) return default;
        return new GetGlassByIdQueryResult()
        {
            Id = value.Id,
            Material = value.Material,
            Category = value.Category,
        };
        
    }
}