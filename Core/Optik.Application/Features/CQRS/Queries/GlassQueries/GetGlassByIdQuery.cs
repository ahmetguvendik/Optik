using MediatR;
using Optik.Application.Features.CQRS.Results.GlassResults;

namespace Optik.Application.Features.CQRS.Queries.GlassQueries;

public class GetGlassByIdQuery : IRequest<GetGlassByIdQueryResult>
{
    public string Id { get; set; }

    public GetGlassByIdQuery(string id)
    {
         Id = id;
    }
}