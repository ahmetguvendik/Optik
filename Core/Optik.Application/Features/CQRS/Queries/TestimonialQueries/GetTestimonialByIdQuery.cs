using MediatR;
using Optik.Application.Features.CQRS.Results.TestimonialResults;

namespace Optik.Application.Features.CQRS.Queries.TestimonialQueries;

public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
{
    public string Id { get; set; }

    public GetTestimonialByIdQuery(string id)
    {
         Id = id;
    }
}