using MediatR;
using Optik.Application.Features.CQRS.Queries.AboutQueries;
using Optik.Application.Features.CQRS.Results.AboutResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.AboutHandlers.Read;

public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery,List<GetAboutQueryResult>>
{
    private readonly IRepository<About> _repository;

    public GetAboutQueryHandler(IRepository<About> repository)
    {
         _repository = repository;
    }
    
    public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAllAsync();
        return value.Select(x => new GetAboutQueryResult
        {
            Description = x.Description,
             Id = x.Id,
             ImageURL = x.ImageURL,
             Title = x.Title,
        }).ToList();
    }
}