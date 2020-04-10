
using AutoMapper;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.DependencyResolver
{
    public class AutomapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToConstant(CreatConfiguration().CreateMapper()).InSingletonScope();
        }


        private MapperConfiguration CreatConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfiles(GetType().Assembly);
                });
            return config;
        }
    }
}
