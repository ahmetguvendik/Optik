using MediatR;
using Optik.Application.Features.CQRS.Commands.GlassCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassHandlers.Write;

public class RemoveGlassCommandHandler : IRequestHandler<RemoveGlassCommand>
{
    private readonly IRepository<Glass> _repository;

    public RemoveGlassCommandHandler( IRepository<Glass> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveGlassCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        if (value == null) throw new Exception("Glass not found");
        await _repository.RemoveAsync(value);
        await _repository.SaveChangesAsync();
    }
}