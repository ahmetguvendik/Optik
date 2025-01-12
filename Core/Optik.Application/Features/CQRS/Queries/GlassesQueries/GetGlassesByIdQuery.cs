using MediatR;
using Optik.Application.Features.CQRS.Results.GlassesResults;

namespace Optik.Application.Features.CQRS.Queries.GlassesQueries;

public class GetGlassesByIdQuery : IRequest<GetGlassesByIdQueryResult>
{
    public string Id { get; set; }

    public GetGlassesByIdQuery(string id)
    {
         Id = id;
    }
}