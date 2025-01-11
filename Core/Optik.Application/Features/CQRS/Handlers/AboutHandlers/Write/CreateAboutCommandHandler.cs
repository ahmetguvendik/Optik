using MediatR;
using Optik.Application.Features.CQRS.Commands.AboutCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.AboutHandlers.Write;

public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
{
    private readonly IRepository<About> _repository;

    public CreateAboutCommandHandler( IRepository<About> repository)
    {
         _repository = repository;
    }
    public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
    {
        var value = new About();
        value.Id = Guid.NewGuid().ToString();
        value.Title = request.Title;
        value.Description = request.Description;
        value.ImageURL = request.ImageURL;
        await _repository.CreateAsync(value);
        await _repository.SaveChangesAsync();
    }
}