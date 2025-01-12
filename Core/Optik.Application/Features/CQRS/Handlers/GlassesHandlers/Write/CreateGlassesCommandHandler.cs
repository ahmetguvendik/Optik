using MediatR;
using Optik.Application.Features.CQRS.Commands.GlassesCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassesHandlers.Write;

public class CreateGlassesCommandHandler : IRequestHandler<CreateGlassesCommand>
{
    private readonly IRepository<Glasses> _repository;

    public CreateGlassesCommandHandler( IRepository<Glasses> repository)
    {
         _repository = repository;
    }
    public async Task Handle(CreateGlassesCommand request, CancellationToken cancellationToken)
    {
        var glasses = new Glasses();
        glasses.Id = Guid.NewGuid().ToString();
        glasses.ProductCode = request.ProductCode;
        glasses.Model = request.Model;
        glasses.Gender = request.Gender;
        glasses.Ayna = request.Ayna;
        glasses.GlassID = request.GlassID;
        glasses.FrameID = request.FrameID;
        glasses.BrandID = request.BrandID;
        glasses.Price = request.Price;
        glasses.Description = request.Description;
        glasses.Polarize  = request.Polarize;
        glasses.KopruLenght = request.KopruLenght;
        glasses.SapLenght = request.SapLenght;
        glasses.Degrade = request.Degrade;
        glasses.Polarize  = request.Polarize;
        await _repository.CreateAsync(glasses);
        await _repository.SaveChangesAsync();
    }
}