using MediatR;

namespace Optik.Application.Features.CQRS.Commands.GlassesCommands;

public class UpdateGlassesCommand : IRequest
{
    public string Id { get; set; }  
    public string Model { get; set; }
    public bool Gender { get; set; }
    public string ProductCode { get; set; }
    public bool Polarize { get; set; }
    public bool Degrade { get; set; }
    public bool Ayna { get; set; }
    public int KopruLenght { get; set; }
    public int SapLenght { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string BrandID { get; set; }
    public string GlassID { get; set; }
    public string FrameID { get; set; }
}