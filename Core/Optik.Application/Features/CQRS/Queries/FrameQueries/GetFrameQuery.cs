using MediatR;
using Optik.Application.Features.CQRS.Results.FrameResults;

namespace Optik.Application.Features.CQRS.Queries.FrameQueries;

public class GetFrameQuery : IRequest<List<GetFrameQueryResult>>
{
    
}