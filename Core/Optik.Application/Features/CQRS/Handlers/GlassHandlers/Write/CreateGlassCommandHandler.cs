using MediatR;
using Optik.Application.Features.CQRS.Commands.GlassCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassHandlers.Write;

public class CreateGlassCommandHandler : IRequestHandler<CreateGlassCommand>
{
    private readonly IRepository<Glass> _repository;

    public CreateGlassCommandHandler( IRepository<Glass> repository)
    {
         _repository = repository;
    }
    public async Task Handle(CreateGlassCommand request, CancellationToken cancellationToken)
    {
        var x = new Glass();
        x.Id = Guid.NewGuid().ToString();
        x.Category = request.Category;
        x.Material = request.Material;
        await _repository.CreateAsync(x);
        await _repository.SaveChangesAsync();
        
    }
}