using MediatR;
using Optik.Application.Features.CQRS.Commands.FooterCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FooterHandlers.Write;

public class RemoveFooterCommandHandler : IRequestHandler<RemoveFooterCommand>
{
    private readonly IRepository<Footer> _repository;

    public RemoveFooterCommandHandler( IRepository<Footer> repository)
    {
         _repository = repository;
    }
    public async Task Handle(RemoveFooterCommand request, CancellationToken cancellationToken)
    {
      var value = await _repository.GetByIdAsync(request.Id);
      await _repository.RemoveAsync(value);
      await _repository.SaveChangesAsync();
    }
}