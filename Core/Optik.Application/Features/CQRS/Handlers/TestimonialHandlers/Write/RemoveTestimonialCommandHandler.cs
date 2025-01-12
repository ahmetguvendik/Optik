using MediatR;
using Optik.Application.Features.CQRS.Commands.TestimonialCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.TestimonialHandlers.Write;

public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public RemoveTestimonialCommandHandler( IRepository<Testimonial> repository)
    {
        _repository = repository;
    }
    public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
    {
        var x = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(x);
        await _repository.SaveChangesAsync();
    }
}