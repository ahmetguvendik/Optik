using MediatR;

namespace Optik.Application.Features.CQRS.Commands.BrandCommands;

public class UpdateBrandCommand : IRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
}