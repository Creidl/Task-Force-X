using Microsoft.EntityFrameworkCore;
using Task_Force.Entities;

namespace Task_Force.Repositories
{
    public class SqlRepository<T> : IRepository<T>
        where T : class, IEntity
    {
        private DbSet<T> _dbSet;
        private DbContext _dbContext;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}