using MediatR;
using Optik.Application.Features.CQRS.Commands.AboutCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.AboutHandlers.Write;

public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommond>
{
    private readonly IRepository<About> _repository;

    public UpdateAboutCommandHandler( IRepository<About> repository)
    {
         _repository = repository;
    }
    public async Task Handle(UpdateAboutCommond request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        value.Title = request.Title;
        value.Description = request.Description;
        value.ImageURL = request.ImageURL;
        await _repository.UpdateAsync(value);
        await _repository.SaveChangesAsync();
    }
}