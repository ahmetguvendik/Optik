using MediatR;
using Optik.Application.Features.CQRS.Commands.ContactCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ContactHandlers.Write;

public class RemoveContactCommandHandler : IRequestHandler<RemoveContactCommand>
{
    private readonly IRepository<Contact> _repository;

    public RemoveContactCommandHandler( IRepository<Contact> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveContactCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
        await _repository.SaveChangesAsync();
    }
}