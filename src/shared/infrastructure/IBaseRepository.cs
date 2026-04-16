namespace Somnguard.Backend.shared.infrastructure
{
   public interface IBaseRepository<T> where T : class
{
    // READ
    Task<T> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    
    // CREATE
    Task<T> CreateAsync(T entity);
    
    // UPDATE
    Task<T> UpdateAsync(Guid id, T entity);
    
    // DELETE
    Task DeleteAsync(Guid id);
    
    // HELPERS
    Task<bool> ExistsAsync(Guid id);
    Task SaveChangesAsync();

}
}
