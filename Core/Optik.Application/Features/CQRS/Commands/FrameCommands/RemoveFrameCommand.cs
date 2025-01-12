using MediatR;

namespace Optik.Application.Features.CQRS.Commands.FrameCommands;

public class RemoveFrameCommand : IRequest
{
    public string Id { get; set; }

    public RemoveFrameCommand(string id)
    {
         Id = id;
    }
}