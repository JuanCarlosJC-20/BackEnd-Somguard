using Microsoft.EntityFrameworkCore;
using Somnguard.Backend.Security.infrastructure;

namespace Somnguard.Backend.shared.infrastructure
{
   public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    // Inyecta DbContext (ya que es genérica, sirve para cualquier entity)
    protected readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // READ
    public async Task<T> GetByIdAsync(Guid id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null)
            throw new KeyNotFoundException($"{typeof(T).Name} con ID {id} no encontrado");
        return entity;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    // CREATE
    public async Task<T> CreateAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    // UPDATE
    public async Task<T> UpdateAsync(Guid id, T entity)
    {
        var existing = await GetByIdAsync(id);
        _context.Entry(existing).CurrentValues.SetValues(entity);
        await _context.SaveChangesAsync();
        return existing;
    }

    // DELETE
    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    // HELPERS
    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _context.Set<T>().FindAsync(id) != null;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
}
