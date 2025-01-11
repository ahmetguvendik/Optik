using MediatR;
using Optik.Application.Features.CQRS.Commands.AboutCommands;
using Optik.Application.Features.CQRS.Commands.BannerCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BannerHandlers.Write;

public class RemoveBannerCommandHandler : IRequestHandler<RemoveBannerCommand>
{
    private readonly IRepository<Banner> _repository;

    public RemoveBannerCommandHandler( IRepository<Banner> repository)
    {
         _repository = repository;
    }
    public async Task Handle(RemoveBannerCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
        await _repository.SaveChangesAsync();
    }
}