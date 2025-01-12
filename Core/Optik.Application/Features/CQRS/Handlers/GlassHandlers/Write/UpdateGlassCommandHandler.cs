using MediatR;
using Optik.Application.Features.CQRS.Commands.GlassCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassHandlers.Write;

public class UpdateGlassCommandHandler : IRequestHandler<UpdateGlassCommand>
{
    private readonly IRepository<Glass> _repository;

    public UpdateGlassCommandHandler( IRepository<Glass> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateGlassCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        value.Category = request.Category;
        value.Material = request.Material;
        await _repository.UpdateAsync(value);
        await _repository.SaveChangesAsync();
    }
}