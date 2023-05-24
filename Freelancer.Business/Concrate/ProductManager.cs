using System;
using System.Collections.Generic;
using System.Linq;
using Freelancer.Business.Abstract;
using Freelancer.Business.Utilities;
using Freelancer.Business.ValidationRules.FluentValidation;
using Freelancer.DataAccess.Abstract;
using Freelancer.Entities.Concrate;

namespace Freelancer.Business.Concrate
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //business code kontrol kurallari gibi
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public Dictionary<string, int> GetCategoryNamesIds()
        {
            return _productDal.GetCategoryNamesIds();
        }


        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}