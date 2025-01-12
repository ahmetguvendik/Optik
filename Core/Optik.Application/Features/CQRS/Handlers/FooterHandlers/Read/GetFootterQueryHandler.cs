using MediatR;
using Optik.Application.Features.CQRS.Queries.FooterQueries;
using Optik.Application.Features.CQRS.Results.FooterResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FooterHandlers.Read;

public class GetFootterQueryHandler : IRequestHandler<GetFooterQuery,List<GetFooterQueryResult>>
{
    private readonly IRepository<Footer> _repository;

    public GetFootterQueryHandler( IRepository<Footer> repository)
    {
         _repository = repository;
    }
    public async Task<List<GetFooterQueryResult>> Handle(GetFooterQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetFooterQueryResult
        {
            Email = x.Email,
            InstagramURL = x.InstagramURL,
            PhoneNumber = x.PhoneNumber,
            Id = x.Id,
            Adress = x.Adress,
        }).ToList();
    }
}