using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Freelancer.DataAccess.Abstract;
using Freelancer.Entities.Abstract;

namespace Freelancer.DataAccess.Concrate.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext, Product> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
        where Product : Entities.Concrate.Product
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public Dictionary<string, int> GetCategoryNamesIds()
        {
            using (var context = new TContext())
            {
                var temp = new Dictionary<string, int>();
                var keylist = context.Set<Product>().Select(p => p.CategoryName).Distinct().ToList();
                var valuelist = new List<int>();
                foreach (var v in keylist)
                {
                    var value = context.Set<Product>().Where(p => p.CategoryName == v).FirstOrDefault();
                    valuelist.Add(value.CategoryId);
                }


                for (var i = 0; i < keylist.Count; i++) temp.Add(keylist[i], valuelist[i]);
                return temp;
            }
        }


        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}