using MediatR;
using Optik.Application.Features.CQRS.Queries.AboutQueries;
using Optik.Application.Features.CQRS.Results.AboutResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.AboutHandlers.Read;

public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery,GetAboutbyIdQueryResult>
{
    private readonly IRepository<About> _repository;

    public GetAboutByIdQueryHandler( IRepository<About> repository)
    {
         _repository = repository;
    }
    
    public async Task<GetAboutbyIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetAboutbyIdQueryResult
        {
            Description = value.Description,
             ImageURL = value.ImageURL,
             Title = value.Title,
             Id = value.Id,
        };
    }
}