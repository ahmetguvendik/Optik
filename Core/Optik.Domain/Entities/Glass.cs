namespace Optik.Domain.Entities;

public class Glass : BaseEntity
{
    public string Category { get; set; }
    public string Material { get; set; }
    public List<Glasses> GlassesList { get; set; }  
    
}