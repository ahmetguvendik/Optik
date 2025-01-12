using MediatR;
using Optik.Application.Features.CQRS.Results.GlassResults;

namespace Optik.Application.Features.CQRS.Queries.GlassQueries;

public class GetGlassQuery : IRequest<List<GetGlassQueryResult>>
{
    
}