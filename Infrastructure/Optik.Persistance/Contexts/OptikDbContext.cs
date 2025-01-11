using Microsoft.EntityFrameworkCore;
using Optik.Domain.Entities;

namespace Optik.Persistance.Contexts;

public class OptikDbContext : DbContext
{
    public OptikDbContext(DbContextOptions options) : base(options) { }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Footer> Footers { get; set; }
    public DbSet<Frame> Frames { get; set; }
    public DbSet<Glasses> Glasses { get; set; }
    public DbSet<Glass> Glass { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }    
    public DbSet<Banner> Banners { get; set; }      
        
}