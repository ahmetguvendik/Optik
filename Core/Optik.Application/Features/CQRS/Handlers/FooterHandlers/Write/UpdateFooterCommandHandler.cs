using MediatR;
using Optik.Application.Features.CQRS.Commands.FooterCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FooterHandlers.Write;

public class UpdateFooterCommandHandler : IRequestHandler<UpdateFooterCommand>
{
    private readonly IRepository<Footer> _repository;

    public UpdateFooterCommandHandler( IRepository<Footer> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateFooterCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        value.Adress = request.Adress;
        value.Email = request.Email;
        value.PhoneNumber = request.PhoneNumber;
        value.InstagramURL = request.InstagramURL;
        await _repository.UpdateAsync(value);
        await _repository.SaveChangesAsync();
    }
}