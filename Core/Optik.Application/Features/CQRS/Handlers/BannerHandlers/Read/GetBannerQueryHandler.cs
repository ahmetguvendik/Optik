using MediatR;
using Optik.Application.Features.CQRS.Queries.BannerQueries;
using Optik.Application.Features.CQRS.Results.BannerResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BannerHandlers.Read;

public class GetBannerQueryHandler : IRequestHandler<GetBannerQuery, List<GetBannerQueryResult>>
{
    private readonly IRepository<Banner> _repository;

    public GetBannerQueryHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }
    
    public async Task<List<GetBannerQueryResult>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAllAsync();
        return value.Select(x => new GetBannerQueryResult
        {
            Id = x.Id,
            ImageURL = x.ImageURL,
            Title = x.Title,
        }).ToList();
    }
}