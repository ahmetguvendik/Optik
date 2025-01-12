using MediatR;
using Optik.Application.Features.CQRS.Results.TestimonialResults;

namespace Optik.Application.Features.CQRS.Queries.TestimonialQueries;

public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
{
    
}