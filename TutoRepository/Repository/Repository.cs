using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TutoRepository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext Context)
        {
            this.Context = Context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).AsEnumerable();
            
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsEnumerable();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
            Context.SaveChanges();
        }
    }
}
