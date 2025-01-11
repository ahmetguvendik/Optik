using MediatR;
using Optik.Application.Features.CQRS.Queries.ContactQueries;
using Optik.Application.Features.CQRS.Results.ContactResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ContactHandlers.Read;

public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
{
    private readonly IRepository<Contact> _repository;

    public GetContactQueryHandler( IRepository<Contact> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetContactQueryResult
        {
         Email = x.Email,
         Name = x.Name,
         Message = x.Message,
         PhoneNumber = x.PhoneNumber,
         Id = x.Id,
        }).ToList();
    }
}