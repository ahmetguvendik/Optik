using MediatR;
using Optik.Application.Features.CQRS.Results.AboutResults;

namespace Optik.Application.Features.CQRS.Queries.AboutQueries;

public class GetAboutQuery : IRequest<List<GetAboutQueryResult>>
{
    
}