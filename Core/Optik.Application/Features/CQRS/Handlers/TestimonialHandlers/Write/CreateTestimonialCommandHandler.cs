using MediatR;
using Optik.Application.Features.CQRS.Commands.TestimonialCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.TestimonialHandlers.Write;

public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public CreateTestimonialCommandHandler( IRepository<Testimonial> repository)
    {
         _repository = repository;
    }
    public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var x = new Testimonial();
        x.Id = Guid.NewGuid().ToString();
        x.Title = request.Title;
        x.Description = request.Description;
        x.ImageURL = request.ImageURL;
        x.Name = request.Name;
        x.Message = request.Message;
        await _repository.CreateAsync( x );
        await _repository.SaveChangesAsync();
    }
}