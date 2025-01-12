using MediatR;
using Optik.Application.Features.CQRS.Queries.FrameQueries;
using Optik.Application.Features.CQRS.Results.FrameResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FrameHandlers.Read;

public class GetFrameQueryHandler : IRequestHandler<GetFrameQuery, List<GetFrameQueryResult>>
{
    private readonly IRepository<Frame> _frameRepository;

    public GetFrameQueryHandler( IRepository<Frame> frameRepository)
    {
        _frameRepository = frameRepository;
    }
    public async Task<List<GetFrameQueryResult>> Handle(GetFrameQuery request, CancellationToken cancellationToken)
    {
        var values = await _frameRepository.GetAllAsync();
        return values.Select(x => new GetFrameQueryResult
        {
            Id = x.Id,
            Name = x.Name,

        }).ToList();
    }
}