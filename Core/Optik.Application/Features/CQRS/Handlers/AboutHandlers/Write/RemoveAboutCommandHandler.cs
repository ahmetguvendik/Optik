using MediatR;
using Optik.Application.Features.CQRS.Commands.AboutCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.AboutHandlers.Write;

public class RemoveAboutCommandHandler : IRequestHandler<RemoveAboutCommand>
{
    private readonly IRepository<About> _repository;

    public RemoveAboutCommandHandler( IRepository<About> repository)
    {
         _repository = repository;
    }
    public async Task Handle(RemoveAboutCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.id);
        await _repository.RemoveAsync(value);
        await _repository.SaveChangesAsync();
        
    }
}