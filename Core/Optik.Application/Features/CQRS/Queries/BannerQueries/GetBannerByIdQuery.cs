using MediatR;
using Optik.Application.Features.CQRS.Results.BannerResults;

namespace Optik.Application.Features.CQRS.Queries.BannerQueries;

public class GetBannerByIdQuery : IRequest<GetBannerByIdQueryResult>
{
    public string Id { get; set; }

    public GetBannerByIdQuery(string id)
    {
         Id = id;
    }
}