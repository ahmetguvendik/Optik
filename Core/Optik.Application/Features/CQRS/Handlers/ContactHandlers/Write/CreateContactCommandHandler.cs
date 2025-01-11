using MediatR;
using Optik.Application.Features.CQRS.Commands.ContactCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ContactHandlers.Write;

public class CreateContactCommandHandler : IRequestHandler<CreataContactCommand>
{
    private readonly IRepository<Contact> _repository;

    public CreateContactCommandHandler( IRepository<Contact> repository)
    {
             _repository = repository;
    }
    public async Task Handle(CreataContactCommand request, CancellationToken cancellationToken)
    {
        var contact = new Contact();
        contact.Id = Guid.NewGuid().ToString();
        contact.Name = request.Name;
        contact.Email = request.Email;
        contact.PhoneNumber = request.PhoneNumber;
        contact.Message = request.Message;
        await _repository.CreateAsync(contact);
        await _repository.SaveChangesAsync();
    }
}