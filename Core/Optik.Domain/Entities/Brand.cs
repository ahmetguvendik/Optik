namespace Optik.Domain.Entities;

public class Brand : BaseEntity
{
    public string Name { get; set; }
    public List<Glasses> GaGlassesList { get; set; }
}