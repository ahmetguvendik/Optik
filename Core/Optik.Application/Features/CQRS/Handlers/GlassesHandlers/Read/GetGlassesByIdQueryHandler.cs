using MediatR;
using Optik.Application.Features.CQRS.Queries.GlassesQueries;
using Optik.Application.Features.CQRS.Results.GlassesResults;
using Optik.Application.Features.CQRS.Results.GlassResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassesHandlers.Read;

public class GetGlassesByIdQueryHandler : IRequestHandler<GetGlassesByIdQuery, GetGlassesByIdQueryResult>
{
    private readonly IRepository<Glasses> _repository;

    public GetGlassesByIdQueryHandler( IRepository<Glasses> repository)
    {
        _repository = repository;
    }
    public async Task<GetGlassesByIdQueryResult> Handle(GetGlassesByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetGlassesByIdQueryResult()
        {
            Ayna = value.Ayna,
            Degrade = value.Degrade,
            Description = value.Description,
            Polarize = value.Polarize,
            SapLenght = value.SapLenght,
            KopruLenght = value.KopruLenght,
            Id = value.Id,
            FrameID = value.FrameID,
            Price = value.Price,
            ProductCode = value.ProductCode,
            BrandID = value.BrandID,
            GlassID = value.GlassID,
            Gender = value.Gender,
            Model = value.Model,
        };
    }
}