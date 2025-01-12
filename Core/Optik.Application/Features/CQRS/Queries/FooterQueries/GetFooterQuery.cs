using MediatR;
using Optik.Application.Features.CQRS.Results.FooterResults;

namespace Optik.Application.Features.CQRS.Queries.FooterQueries;

public class GetFooterQuery : IRequest<List<GetFooterQueryResult>>
{
    
}