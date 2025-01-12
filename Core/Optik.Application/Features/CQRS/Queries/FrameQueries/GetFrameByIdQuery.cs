using MediatR;
using Optik.Application.Features.CQRS.Results.FrameResults;

namespace Optik.Application.Features.CQRS.Queries.FrameQueries;

public class GetFrameByIdQuery : IRequest<GetFrameByIdQueryResult>
{
    public string Id { get; set; }

    public GetFrameByIdQuery(string id)
    {
         Id = id;
    }
}