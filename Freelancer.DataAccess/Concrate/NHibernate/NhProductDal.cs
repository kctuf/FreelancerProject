using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Freelancer.DataAccess.Abstract;
using Freelancer.Entities.Concrate;

namespace Freelancer.DataAccess.Concrate.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductId = 1, ProductName = "Laptop",
                    CategoryId = 1, UnitPrice = 34, UnitsInStock = 30, QuantityPerUnit = "35"
                }
            };
            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> GetCategoryNamesIds()
        {
            throw new NotImplementedException();
        }


        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}