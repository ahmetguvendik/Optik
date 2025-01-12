using MediatR;
using Optik.Application.Features.CQRS.Commands.TestimonialCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.TestimonialHandlers.Write;

public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public UpdateTestimonialCommandHandler( IRepository<Testimonial> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var x = await _repository.GetByIdAsync(request.Id);
        x.Title = request.Title;
        x.Description = request.Description;
        x.Message = request.Message;
        x.Name = request.Name;
        x.ImageURL = request.ImageURL;
        await _repository.UpdateAsync(x);
        await _repository.SaveChangesAsync();
    }
}