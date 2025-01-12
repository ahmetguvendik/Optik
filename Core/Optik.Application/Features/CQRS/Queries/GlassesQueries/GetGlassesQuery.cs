using MediatR;
using Optik.Application.Features.CQRS.Results.GlassesResults;
using Optik.Application.Features.CQRS.Results.GlassResults;

namespace Optik.Application.Features.CQRS.Queries.GlassesQueries;

public class GetGlassesQuery : IRequest<List<GetGlassesQueryResult>>
{
    
}