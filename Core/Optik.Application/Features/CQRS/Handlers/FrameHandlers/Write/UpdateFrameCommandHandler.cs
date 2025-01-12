using MediatR;
using Optik.Application.Features.CQRS.Commands.FrameCommands;
using Optik.Application.Repositories;
using Optik.Domain.Entities;

namespace Optik.Application.Features.CQRS.Handlers.FrameHandlers.Write;

public class UpdateFrameCommandHandler : IRequestHandler<UpdateFrameCommand>
{
    private readonly IRepository<Frame> _frameRepository;

    public UpdateFrameCommandHandler( IRepository<Frame> frameRepository)
    {
        _frameRepository = frameRepository;
    }
    public async Task Handle(UpdateFrameCommand request, CancellationToken cancellationToken)
    {
        var frame = await _frameRepository.GetByIdAsync(request.Id);
        frame.Name = request.Name;
        await _frameRepository.UpdateAsync(frame);
        await _frameRepository.SaveChangesAsync();
    }
}