using MediatR;
using Optik.Application.Features.CQRS.Queries.FooterQueries;
using Optik.Application.Features.CQRS.Results.FooterResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FooterHandlers.Read;

public class GetFooterByIdQueryHandler : IRequestHandler<GetFooterByIdQuery, GetFooterByIdQueryResult>
{
     private readonly IRepository<Footer> _repository;

     public GetFooterByIdQueryHandler( IRepository<Footer> repository)
     {
          _repository = repository;
     }
    public async Task<GetFooterByIdQueryResult> Handle(GetFooterByIdQuery request, CancellationToken cancellationToken)
    {
        var valeu = await _repository.GetByIdAsync(request.Id);
        return new GetFooterByIdQueryResult()
        {
            Adress = valeu.Adress,
            Email = valeu.Email,
            InstagramURL = valeu.InstagramURL,
            PhoneNumber = valeu.PhoneNumber,
            Id = valeu.Id,
        };
    }
}