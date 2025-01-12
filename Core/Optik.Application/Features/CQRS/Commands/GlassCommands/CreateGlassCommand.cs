using MediatR;

namespace Optik.Application.Features.CQRS.Commands.GlassCommands;

public class CreateGlassCommand : IRequest
{
    public string Category { get; set; }
    public string Material { get; set; }
}