using MediatR;
using Optik.Application.Features.CQRS.Queries.FrameQueries;
using Optik.Application.Features.CQRS.Results.FrameResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FrameHandlers.Read;

public class GetFrameByIdQueryHandler : IRequestHandler<GetFrameByIdQuery, GetFrameByIdQueryResult>
{
    private readonly IRepository<Frame> _frameRepository;

    public GetFrameByIdQueryHandler( IRepository<Frame> frameRepository)
    {
        _frameRepository = frameRepository;
    }
    public async Task<GetFrameByIdQueryResult> Handle(GetFrameByIdQuery request, CancellationToken cancellationToken)
    {
       var frame = await _frameRepository.GetByIdAsync(request.Id);
       return new GetFrameByIdQueryResult()
       {
           Id = frame.Id,
           Name = frame.Name,
       };
    }
}