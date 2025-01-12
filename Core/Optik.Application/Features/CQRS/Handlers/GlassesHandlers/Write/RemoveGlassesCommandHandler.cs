using MediatR;
using Optik.Application.Features.CQRS.Commands.GlassesCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassesHandlers.Write;

public class RemoveGlassesCommandHandler : IRequestHandler<RemoveGlassesCommand>
{   
    private readonly IRepository<Glasses> _repository;

    public RemoveGlassesCommandHandler( IRepository<Glasses> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveGlassesCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
        await _repository.SaveChangesAsync();
        
    }
}