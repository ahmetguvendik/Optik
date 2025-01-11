using MediatR;

namespace Optik.Application.Features.CQRS.Commands.BannerCommands;

public class CreateBannerCommand : IRequest
{
    public string Title { get; set; }
    public string ImageURL { get; set; }
}