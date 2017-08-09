using Exam.Domain.Core.Interfaces.Repositories;
using Examinition.Web.Core.Models;
using System.Data.Entity;

namespace Exam.Infrastructure.Core.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private ApplicationDbContext _dbContext;
        private DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<T>();

        }
        public virtual void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }

        public System.Collections.Generic.IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public T GetById(params object[] id)
        {
            return dbSet.Find(id);
        }

        public T Add(T Item)
        {
            return dbSet.Add(Item);
        }

        public void DeleteById(int id)
        {
            T entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }

        public void UpdateById(T Item)
        {
            _dbContext.Entry(Item).State = EntityState.Modified;
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }
      
    }
}
