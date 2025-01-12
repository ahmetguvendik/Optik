using MediatR;
using Optik.Application.Features.CQRS.Results.FooterResults;

namespace Optik.Application.Features.CQRS.Queries.FooterQueries;

public class GetFooterByIdQuery : IRequest<GetFooterByIdQueryResult>
{
    public string Id { get; set; }

    public GetFooterByIdQuery(string id)
    {
         Id = id;
    }
}