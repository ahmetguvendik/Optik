using MediatR;

namespace Optik.Application.Features.CQRS.Commands.GlassesCommands;

public class RemoveGlassesCommand : IRequest
{
    public string Id { get; set; }

    public RemoveGlassesCommand(string id)
    {
             Id = id;
    }
}