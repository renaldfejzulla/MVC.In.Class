using Microsoft.EntityFrameworkCore;
using MVC.In.Class.DataAcessLayer.Context;
using System.Diagnostics;

namespace MVC.In.Class.DataAcessLayer.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly LibraryDBContext _context;
        private DbSet<T> table = null;
        
        public Repository()
        {
            this._context= new LibraryDBContext();
            table = _context.Set<T>();
        }

        public Repository(LibraryDBContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public async void Delete(object id)
        {
            T exist= await table.FindAsync(id);
            table.Remove(exist);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            table = _context.Set<T>();
            
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }

}
