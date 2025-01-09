using Microsoft.EntityFrameworkCore;
using Optik.Application.Repositories;
using Optik.Persistance.Contexts;

namespace Optik.Persistance.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly OptikDbContext _optikDbContext;
    public Repository(OptikDbContext optikDbContext)
    {
        _optikDbContext = optikDbContext;
    }

    public async Task CreateAsync(T entity)
    {
        _optikDbContext.Add(entity);
        await _optikDbContext.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _optikDbContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(string id)
    {
        return await _optikDbContext.Set<T>().FindAsync(id);
    }

    public async Task RemoveAsync(T entity)
    {
        _optikDbContext.Set<T>().Remove(entity);
        await _optikDbContext.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _optikDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _optikDbContext.Set<T>().Update(entity);
        await _optikDbContext.SaveChangesAsync();
    }
}