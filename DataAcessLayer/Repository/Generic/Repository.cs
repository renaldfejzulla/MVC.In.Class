using MVC.In.Class.DataAcessLayer.Context;

namespace MVC.In.Class.DataAcessLayer.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly LibraryDBContext _context;

        public Repository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task ComitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var result = await _context.AddAsync(entity);
            return result.Entity;
        }

        public async void DeleteAsync(T entity)
        {
            var get = entity.GetType().GetProperty("IsDeleted");
            if (get != null)
            {
                entity.GetType().GetProperty("IsDeleted").SetValue(entity, false);
            }
            _context.Update(entity);
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
