using MediatR;

namespace Optik.Application.Features.CQRS.Commands.FrameCommands;

public class CreateFrameCommand : IRequest
{
    public string Name { get; set; }
}