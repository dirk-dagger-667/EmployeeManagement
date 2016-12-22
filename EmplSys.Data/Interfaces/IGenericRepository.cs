namespace EmplSys.Data.Interfaces
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> SearchFor(Expression<Func<T, bool>> conditions);

        IQueryable<T> Include(string path);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Detach(T enitty);

        int SaveChanges();
    }
}
