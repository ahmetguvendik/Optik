using MediatR;
using Optik.Application.Features.CQRS.Commands.ContactCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ContactHandlers.Write;

public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler( IRepository<Contact> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
       var value = await _repository.GetByIdAsync(request.Id);
       value.Message = request.Message;
       value.Name = request.Name;
       value.Email = request.Email;
       value.Message = request.Message;
       await _repository.UpdateAsync(value);
       await _repository.SaveChangesAsync();

    }
}