using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Optik.Application.Repositories;
using Optik.Persistance.Contexts;
using Optik.Persistance.Repositories;

namespace Optik.Persistance;

public static class ServiceRegistration
{
    public static void AddPersistanceService(this IServiceCollection collection)
    {
        collection.AddDbContext<OptikDbContext>(opt =>
            opt.UseNpgsql("User ID=postgres;Password=testtest;Host=localhost;Port=5432;Database=OptikDb;"));
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        collection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}