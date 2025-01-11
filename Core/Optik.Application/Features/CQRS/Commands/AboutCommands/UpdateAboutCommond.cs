using MediatR;

namespace Optik.Application.Features.CQRS.Commands.AboutCommands;

public class UpdateAboutCommond : IRequest
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
}