using MediatR;
using Optik.Application.Features.CQRS.Results.AboutResults;

namespace Optik.Application.Features.CQRS.Queries.AboutQueries;

public class GetAboutByIdQuery: IRequest<GetAboutbyIdQueryResult>
{
    public string Id { get; set; }

    public GetAboutByIdQuery(string id)
    {
        Id = id;
    }
}