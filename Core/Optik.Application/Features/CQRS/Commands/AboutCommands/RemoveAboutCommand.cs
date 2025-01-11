using MediatR;

namespace Optik.Application.Features.CQRS.Commands.AboutCommands;

public class RemoveAboutCommand : IRequest
{
    public string id { get; set; }

    public RemoveAboutCommand(string Id)
    {
        id = Id;
    }
}