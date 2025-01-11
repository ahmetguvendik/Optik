using MediatR;
using Optik.Application.Features.CQRS.Commands.BannerCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BannerHandlers.Write;

public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommand>
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler( IRepository<Banner> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateBannerCommand request, CancellationToken cancellationToken)
    {
       var value = await _repository.GetByIdAsync(request.Id);
        value.ImageURL = request.ImageURL;
        value.Title = request.Title;
        await _repository.UpdateAsync(value);
        await _repository.SaveChangesAsync();
    }
}