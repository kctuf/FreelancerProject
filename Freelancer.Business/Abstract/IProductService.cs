using System.Collections.Generic;
using Freelancer.Entities.Concrate;

namespace Freelancer.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        Dictionary<string, int> GetCategoryNamesIds();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}