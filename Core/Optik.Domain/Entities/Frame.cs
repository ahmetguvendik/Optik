namespace Optik.Domain.Entities;

public class Frame : BaseEntity
{
    public string Name { get; set; }
    public List<Glasses> GlassesList { get; set; }  
}