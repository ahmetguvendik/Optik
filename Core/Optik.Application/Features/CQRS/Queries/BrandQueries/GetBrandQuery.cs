using MediatR;
using Optik.Application.Features.CQRS.Results.BrandResults;

namespace Optik.Application.Features.CQRS.Queries.BrandQueries;

public class GetBrandQuery : IRequest<List<GetBrandQueryResult>>
{
    
}