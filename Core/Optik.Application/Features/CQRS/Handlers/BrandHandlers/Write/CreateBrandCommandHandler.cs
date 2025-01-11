using MediatR;
using Optik.Application.Features.CQRS.Commands.BannerCommands;
using Optik.Application.Features.CQRS.Commands.BrandCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BrandHandlers.Write;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand>
{
    private readonly IRepository<Brand> _repository;

    public CreateBrandCommandHandler( IRepository<Brand> repository)
    {
          _repository = repository;
    }
    public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        var value = new Brand();
        value.Id = Guid.NewGuid().ToString();
        value.Name = request.Name;
        await _repository.CreateAsync(value);
        await _repository.SaveChangesAsync();
    }
}