using MediatR;

namespace Optik.Application.Features.CQRS.Commands.TestimonialCommands;

public class UpdateTestimonialCommand : IRequest
{
    public string Id { get; set; }  
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
}