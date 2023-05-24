using Freelancer.Business.Abstract;
using Freelancer.Business.Concrate;
using Freelancer.DataAccess.Abstract;
using Freelancer.DataAccess.Concrate.EntityFramework;
using Ninject.Modules;

namespace Freelancer.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
        }
    }
}