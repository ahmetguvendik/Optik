using MediatR;
using Optik.Application.Features.CQRS.Commands.ShopCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ShopHandlers.Write;

public class UpdateShopCommandHandler : IRequestHandler<UpdateShopCommand>
{
    private readonly IRepository<Shop> _repository;

    public UpdateShopCommandHandler( IRepository<Shop> repository )
    {
        _repository = repository;  
    }
    public async Task Handle(UpdateShopCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync( request.Id );
        value.Description = request.Description;
        value.Title = request.Title;
        value.ImageURL = request.ImageURL;
        await _repository.UpdateAsync( value );
        await _repository.SaveChangesAsync();
    }
}