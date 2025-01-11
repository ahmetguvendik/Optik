using MediatR;

namespace Optik.Application.Features.CQRS.Commands.ContactCommands;

public class RemoveContactCommand : IRequest
{
    public string Id { get; set; }

    public RemoveContactCommand( string id )
    {
         Id = id;
    }
}