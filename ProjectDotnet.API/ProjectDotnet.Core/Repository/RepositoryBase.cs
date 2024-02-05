using Microsoft.EntityFrameworkCore;
using ProjectDotnet.Core.Data;

namespace ProjectDotnet.Core.Repository
{
    public class RepositoryBase<T> where T : class
    {
        protected readonly DataContext _context;
        public RepositoryBase(DataContext context) : base() => _context = context;

        public async Task<T?> FindAsync(int id) =>
            await _context.Set<T>().FindAsync(id);
        public async Task<bool> AddAsync(T newObject)
        {
            try
            {
                await _context.Set<T>().AddAsync(newObject);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task AddAsync(IEnumerable<T> newObjects)
        {
            await _context.Set<T>().AddRangeAsync(newObjects);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateAsync(T objectDomain)
        {
            try
            {
                _context.Set<T>().Update(objectDomain);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteAsync(IEnumerable<T> objectDomain)
        {
            try
            {
                _context.Set<T>().RemoveRange(objectDomain);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var objectDomain = await FindAsync(id);
                _context.Set<T>().Remove(objectDomain);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<List<T>> ListAsync() =>
            await _context.Set<T>().ToListAsync();
    }
}
