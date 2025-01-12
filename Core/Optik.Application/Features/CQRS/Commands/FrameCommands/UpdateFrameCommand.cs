using MediatR;

namespace Optik.Application.Features.CQRS.Commands.FrameCommands;

public class UpdateFrameCommand : IRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
}