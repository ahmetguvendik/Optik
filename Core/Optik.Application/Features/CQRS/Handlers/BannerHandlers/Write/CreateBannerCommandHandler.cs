using MediatR;
using Optik.Application.Features.CQRS.Commands.BannerCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BannerHandlers.Write;

public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommand>
{
    private readonly IRepository<Banner> _repository;

    public CreateBannerCommandHandler( IRepository<Banner> repository)
    {
         _repository = repository;
    }
    public async Task Handle(CreateBannerCommand request, CancellationToken cancellationToken)
    {
        var value = new Banner();
        value.Id = Guid.NewGuid().ToString();
        value.Title = request.Title;
        value.ImageURL = request.ImageURL;
        await _repository.CreateAsync(value);
        await _repository.SaveChangesAsync();
    }
}