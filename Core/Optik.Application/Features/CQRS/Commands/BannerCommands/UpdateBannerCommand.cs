using MediatR;

namespace Optik.Application.Features.CQRS.Commands.BannerCommands;

public class UpdateBannerCommand : IRequest
{
    public string Id { get; set; }  
    public string Title { get; set; }
    public string ImageURL { get; set; }
}