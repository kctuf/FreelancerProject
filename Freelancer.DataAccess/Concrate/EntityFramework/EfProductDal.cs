using Freelancer.DataAccess.Abstract;
using Freelancer.Entities.Concrate;

namespace Freelancer.DataAccess.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, FreelancerContext, Product>, IProductDal
    {
    }
}