namespace Optik.Domain.Entities;

public class Glasses : BaseEntity
{
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
    public Brand Brand { get; set; }
    public string BrandID { get; set; }
    public Glass Glass { get; set; }
    public string GlassID { get; set; }
    public Frame Frame { get; set; }
    public string FrameID { get; set; }
}