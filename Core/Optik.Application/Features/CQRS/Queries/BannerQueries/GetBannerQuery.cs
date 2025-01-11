using MediatR;
using Optik.Application.Features.CQRS.Results.BannerResults;

namespace Optik.Application.Features.CQRS.Queries.BannerQueries;

public class GetBannerQuery : IRequest<List<GetBannerQueryResult>>
{
    
}