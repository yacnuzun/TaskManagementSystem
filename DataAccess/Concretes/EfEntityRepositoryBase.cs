using DataAccess.Abstracts;
using Enities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T> 
        where T : class, IEntity, new()
        where TContext: DbContext, new()
    {
        public bool BaseOperations(T entity, EntityState state)
        {
            using (TContext context = new TContext())
            {
                var handledEntity = context.Entry(entity);
                handledEntity.State = state;
                return context.SaveChanges() > 0 ? true : false;
            }
        }
        public bool Add(T entity)
        {
            return BaseOperations(entity, EntityState.Added);
        }

        public bool Delete(T entity)
        {
            return BaseOperations(entity, EntityState.Deleted);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() :
                    context.Set<T>().Where(filter).ToList();
            }
        }

        public bool Update(T entity)
        {
            return BaseOperations(entity, EntityState.Modified);
        }
    }
}
