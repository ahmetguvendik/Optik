using MediatR;

namespace Optik.Application.Features.CQRS.Commands.FooterCommands;

public class RemoveFooterCommand : IRequest
{
    public string Id { get; set; }

    public RemoveFooterCommand(string id)
    {
         Id = id;
    }
}