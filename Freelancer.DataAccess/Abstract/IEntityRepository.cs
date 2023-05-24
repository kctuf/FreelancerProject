using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Freelancer.Entities.Abstract;

namespace Freelancer.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        Dictionary<string, int> GetCategoryNamesIds();

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}