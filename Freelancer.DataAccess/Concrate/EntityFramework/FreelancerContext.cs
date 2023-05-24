using System.Data.Entity;
using Freelancer.Entities.Concrate;

namespace Freelancer.DataAccess.Concrate.EntityFramework
{
    public class FreelancerContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
}