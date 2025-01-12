using MediatR;
using Optik.Application.Features.CQRS.Queries.TestimonialQueries;
using Optik.Application.Features.CQRS.Results.TestimonialResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.TestimonialHandlers.Read;

public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery,List<GetTestimonialQueryResult>>
{
    private readonly IRepository<Testimonial> _repository;

    public GetTestimonialQueryHandler( IRepository<Testimonial> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetTestimonialQueryResult
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
            ImageURL = x.ImageURL,
            Message = x.Message,
            Name = x.Name,

        }).ToList();
    }
}