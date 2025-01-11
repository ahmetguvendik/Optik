using MediatR;
using Optik.Application.Features.CQRS.Results.ContactResults;

namespace Optik.Application.Features.CQRS.Queries.ContactQueries;

public class GetContactByIdQuery : IRequest<GetContactByIdQueryResult>
{
    public string Id { get; set; }

    public GetContactByIdQuery(string id)
    {
         Id = id;
    }
}