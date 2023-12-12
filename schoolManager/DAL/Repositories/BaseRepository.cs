//meme principe que pour la classe mere mais cest la suite en gros

using System;
using System.Linq;
using System.Linq.Expressions;

namespace schoolManager.DAL.Repositories
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly DatabaseContext context;

        public BaseRepository(DatabaseContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> condition)
        {
            return context.Set<TEntity>().Where(condition);
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
    }
}
