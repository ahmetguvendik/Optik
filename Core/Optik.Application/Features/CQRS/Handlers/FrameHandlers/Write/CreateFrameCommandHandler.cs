using MediatR;
using Optik.Application.Features.CQRS.Commands.FrameCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FrameHandlers.Write;


public class CreateFrameCommandHandler : IRequestHandler<CreateFrameCommand>
{
    private readonly IRepository<Frame> _frameRepository;

    public CreateFrameCommandHandler( IRepository<Frame> frameRepository)
    {
             _frameRepository = frameRepository;
    }
    public async Task Handle(CreateFrameCommand request, CancellationToken cancellationToken)
    {
        var value = new Frame();
        value.Id = Guid.NewGuid().ToString();
        value.Name = request.Name;
        await  _frameRepository.CreateAsync(value);
        await  _frameRepository.SaveChangesAsync();
        
    }
}