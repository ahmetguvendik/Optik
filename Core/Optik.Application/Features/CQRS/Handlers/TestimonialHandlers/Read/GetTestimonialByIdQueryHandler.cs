using MediatR;
using Optik.Application.Features.CQRS.Queries.TestimonialQueries;
using Optik.Application.Features.CQRS.Results.TestimonialResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.TestimonialHandlers.Read;

public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery,GetTestimonialByIdQueryResult>
{
    private readonly IRepository<Testimonial> _repository;

    public GetTestimonialByIdQueryHandler( IRepository<Testimonial> repository)
    {
        _repository = repository;
    }
    public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
    {
        var x = await _repository.GetByIdAsync(request.Id);
        return new GetTestimonialByIdQueryResult()
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
            Message = x.Message,
            Name = x.Name,
            ImageURL = x.ImageURL
        };
    }
}