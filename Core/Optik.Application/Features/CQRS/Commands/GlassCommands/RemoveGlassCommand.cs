using MediatR;

namespace Optik.Application.Features.CQRS.Commands.GlassCommands;

public class RemoveGlassCommand : IRequest
{
    public string Id { get; set; }

    public RemoveGlassCommand(string id)
    {
         Id = id;
    }
}