using MediatR;
using Optik.Application.Features.CQRS.Queries.GlassesQueries;
using Optik.Application.Features.CQRS.Results.GlassesResults;
using Optik.Application.Features.CQRS.Results.GlassResults;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.GlassesHandlers.Read;


public class GetGlassesQueryHandler : IRequestHandler<GetGlassesQuery,List<GetGlassesQueryResult>>
{
    private readonly IRepository<Glasses> _repository;

    public GetGlassesQueryHandler( IRepository<Glasses> repository)
    {
         _repository = repository;
    }
    public async Task<List<GetGlassesQueryResult>> Handle(GetGlassesQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetGlassesQueryResult
        {
            Id = x.Id,
            Ayna = x.Ayna,
            SapLenght = x.SapLenght,
            Degrade = x.Degrade,
            Description = x.Description,
            FrameID = x.FrameID,
            BrandID = x.BrandID,
            GlassID = x.GlassID,
            Polarize = x.Polarize,
            ProductCode = x.ProductCode,
            Price = x.Price,
            Gender = x.Gender,
            Model = x.Model,
            
        }).ToList();
    }
}