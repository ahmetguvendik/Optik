using MediatR;

namespace Optik.Application.Features.CQRS.Commands.BrandCommands;

public class CreateBrandCommand : IRequest
{
    public string Name { get; set; }
}