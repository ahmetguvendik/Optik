using MediatR;
using Optik.Application.Features.CQRS.Commands.GlassesCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassesHandlers.Write;

public class UpdateGlassesCommandHandler : IRequestHandler<UpdateGlassesCommand>
{
    private readonly IRepository<Glasses> _repository;

    public UpdateGlassesCommandHandler( IRepository<Glasses> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateGlassesCommand request, CancellationToken cancellationToken)
    {
       var glasses = await _repository.GetByIdAsync(request.Id);
       glasses.Ayna = request.Ayna;
       glasses.GlassID = request.GlassID;
       glasses.Degrade = request.Degrade;
       glasses.Description = request.Description;
       glasses.Gender = request.Gender;
       glasses.Model = request.Model;
       glasses.Polarize = request.Polarize;
       glasses.Price = request.Price;
       glasses.KopruLenght = request.KopruLenght;
       glasses.ProductCode = request.ProductCode;
       glasses.SapLenght = request.SapLenght;
       glasses.BrandID = request.BrandID;
       glasses.FrameID = request.FrameID;
       await _repository.UpdateAsync(glasses);
       await _repository.SaveChangesAsync();
       
    }
}