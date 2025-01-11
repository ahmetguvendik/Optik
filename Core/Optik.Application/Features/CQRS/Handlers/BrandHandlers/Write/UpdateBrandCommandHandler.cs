using MediatR;
using Optik.Application.Features.CQRS.Commands.BrandCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.BrandHandlers.Write;

public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
{
    private readonly IRepository<Brand> _repository;

    public UpdateBrandCommandHandler( IRepository<Brand> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
    {
       var value = await _repository.GetByIdAsync(request.Id);
       value.Name = request.Name;
       await _repository.UpdateAsync(value);
       await _repository.SaveChangesAsync();
    }
}