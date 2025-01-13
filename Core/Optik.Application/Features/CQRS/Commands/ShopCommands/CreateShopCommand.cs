using MediatR;

namespace Optik.Application.Features.CQRS.Commands.ShopCommands;

public class CreateShopCommand : IRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}