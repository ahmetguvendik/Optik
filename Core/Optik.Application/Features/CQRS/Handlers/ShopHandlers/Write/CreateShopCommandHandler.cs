using MediatR;
using Optik.Application.Features.CQRS.Commands.ShopCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ShopHandlers.Write;

public class CreateShopCommandHandler : IRequestHandler<CreateShopCommand>
{
    private readonly IRepository<Shop> _repository;

    public CreateShopCommandHandler( IRepository<Shop> repository )
    {
           _repository = repository;  
    }
    public async Task Handle(CreateShopCommand request, CancellationToken cancellationToken)
    {
        var shop = new Shop();
        shop.Id = Guid.NewGuid().ToString();
        shop.Title = request.Title;
        shop.Description = request.Description;
        shop.ImageURL = request.ImageURL;
        await _repository.CreateAsync(shop);
        await _repository.SaveChangesAsync();
    }
}