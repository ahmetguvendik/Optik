using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Optik.Persistance.Contexts;

namespace Optik.Persistance;

public class DesignTimeDbContext : IDesignTimeDbContextFactory<OptikDbContext>
{

    public OptikDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<OptikDbContext> dbContextOptions = new();
        dbContextOptions.UseNpgsql("User ID=postgres;Password=testtest;Host=localhost;Port=5432;Database=OptikDb;");
        return new(dbContextOptions.Options);
    }
}