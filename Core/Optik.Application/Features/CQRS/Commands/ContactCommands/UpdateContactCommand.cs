using MediatR;

namespace Optik.Application.Features.CQRS.Commands.ContactCommands;

public class UpdateContactCommand : IRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}