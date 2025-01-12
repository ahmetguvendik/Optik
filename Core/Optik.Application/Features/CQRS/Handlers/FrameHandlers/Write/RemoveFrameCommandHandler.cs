using MediatR;
using Optik.Application.Features.CQRS.Commands.FrameCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FrameHandlers.Write;

public class RemoveFrameCommandHandler : IRequestHandler<RemoveFrameCommand>
{
    private readonly IRepository<Frame> _frameRepository;

    public RemoveFrameCommandHandler( IRepository<Frame> frameRepository)
    {
        _frameRepository = frameRepository;
    }
    public async Task Handle(RemoveFrameCommand request, CancellationToken cancellationToken)
    {
        var value = await _frameRepository.GetByIdAsync(request.Id);
        await _frameRepository.RemoveAsync(value);
        await _frameRepository.SaveChangesAsync();
    }
}