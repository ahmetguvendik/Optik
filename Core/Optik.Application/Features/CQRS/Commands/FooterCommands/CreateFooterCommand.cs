using MediatR;

namespace Optik.Application.Features.CQRS.Commands.FooterCommands;

public class CreateFooterCommand : IRequest
{
    public string Adress { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string InstagramURL { get; set; }
}