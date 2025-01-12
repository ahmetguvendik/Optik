using MediatR;

namespace Optik.Application.Features.CQRS.Commands.GlassCommands;

public class UpdateGlassCommand : IRequest
{
    public string Id { get; set; }
    public string Category { get; set; }
    public string Material { get; set; }
}