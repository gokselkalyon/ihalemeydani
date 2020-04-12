using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.Concrete;
using IM.BusinessLayer.ServiceAdapter;
using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.EFConcrete;
using IM.DataLayer;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.DependencyResolver
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataBusinessService<log>>().To<LogManager>().InSingletonScope();
            Bind<IDataAccessDal<log>>().To<LogConcrete>().InSingletonScope();
            Bind<IDataAccessDal<User>>().To<UserConcrete>().InSingletonScope();
            Bind<ITCService>().To<TCServiceAdapter>().InSingletonScope();
        }
    }
}
