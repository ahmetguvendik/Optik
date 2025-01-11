using MediatR;
using Optik.Application.Features.CQRS.Results.ContactResults;

namespace Optik.Application.Features.CQRS.Queries.ContactQueries;

public class GetContactQuery: IRequest<List<GetContactQueryResult>>, IRequest<GetContactByIdQueryResult>
{
    
}