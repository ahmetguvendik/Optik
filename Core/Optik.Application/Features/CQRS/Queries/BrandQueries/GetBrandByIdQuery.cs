using MediatR;
using Optik.Application.Features.CQRS.Results.BannerResults;
using Optik.Application.Features.CQRS.Results.BrandResults;

namespace Optik.Application.Features.CQRS.Queries.BrandQueries;

public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>, IRequest<GetBannerByIdQueryResult>
{
    public string Id { get; set; }

    public GetBrandByIdQuery(string id)
    {
         Id = id;
    }
}