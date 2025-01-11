using MediatR;
using Optik.Application.Features.CQRS.Queries.ContactQueries;
using Optik.Application.Features.CQRS.Results.ContactResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ContactHandlers.Read;

public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler( IRepository<Contact> repository)
    {
        _repository = repository;
    }



    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetContactByIdQueryResult()
        {
            Id = value.Id,
            Name = value.Name,
            PhoneNumber = value.PhoneNumber,
            Email = value.Email,
            Message = value.Message,
        };
    }
}