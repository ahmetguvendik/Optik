using MediatR;
using Optik.Application.Features.CQRS.Commands.FooterCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FooterHandlers.Write;


public class CreateFooterCommandHandler : IRequestHandler<CreateFooterCommand>
{
    private readonly IRepository<Footer> _repository;

    public CreateFooterCommandHandler( IRepository<Footer> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateFooterCommand request, CancellationToken cancellationToken)
    {
        var footer = new Footer();
        footer.Id = Guid.NewGuid().ToString();
        footer.Adress  = request.Adress;
        footer.Email = request.Email;
        footer.PhoneNumber = request.PhoneNumber;
        footer.InstagramURL = request.InstagramURL;
        await _repository.CreateAsync(footer);
        await _repository.SaveChangesAsync();
    }
}