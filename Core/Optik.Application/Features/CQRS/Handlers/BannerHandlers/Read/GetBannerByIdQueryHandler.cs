using MediatR;
using Optik.Application.Features.CQRS.Queries.AboutQueries;
using Optik.Application.Features.CQRS.Queries.BannerQueries;
using Optik.Application.Features.CQRS.Results.AboutResults;
using Optik.Application.Features.CQRS.Results.BannerResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BannerHandlers.Read;


public class GetBannerByIdQueryHandler : IRequestHandler<GetBannerByIdQuery, GetBannerByIdQueryResult>
{
    private readonly IRepository<Banner> _repository;

    public GetBannerByIdQueryHandler( IRepository<Banner> repository)
    {
        _repository = repository;
    }
    

    public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetBannerByIdQueryResult
        { 
            ImageURL = value.ImageURL,
            Title = value.Title,
            Id = value.Id,
        };
    }
}