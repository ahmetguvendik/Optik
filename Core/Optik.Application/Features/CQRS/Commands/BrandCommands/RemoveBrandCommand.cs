using MediatR;

namespace Optik.Application.Features.CQRS.Commands.BrandCommands;

public class RemoveBrandCommand : IRequest
{
    public string Id { get; set; }

    public RemoveBrandCommand(string id)
    {
         Id = id;
    }
}