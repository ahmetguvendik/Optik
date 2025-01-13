using MediatR;
using Optik.Application.Features.CQRS.Commands.ShopCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.ShopHandlers.Write;

public class RemoveShopCommandHandler : IRequestHandler<RemoveShopCommand>
{
    private readonly IRepository<Shop> _repository;

    public RemoveShopCommandHandler( IRepository<Shop> repository )
    {
        _repository = repository;  
    }
    public async Task Handle(RemoveShopCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync( request.Id );
        await _repository.RemoveAsync( value );
        await _repository.SaveChangesAsync();
    }
}