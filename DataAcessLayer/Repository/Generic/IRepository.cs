namespace MVC.In.Class.DataAcessLayer.Repository.Generic
{
    public interface IRepository<T> where T: class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        void DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task ComitAsync();
    }
}
