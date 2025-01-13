using MediatR;

namespace Optik.Application.Features.CQRS.Commands.ShopCommands;

public class RemoveShopCommand : IRequest
{
    public string Id { get; set; }

    public RemoveShopCommand( string id )
    {
         Id = id;
    }
}