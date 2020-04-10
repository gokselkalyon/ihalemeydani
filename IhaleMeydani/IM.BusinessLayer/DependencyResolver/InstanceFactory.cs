using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.DependencyResolver
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var Kernel = new StandardKernel(new BusinessModule(),new AutomapperModule());
            return Kernel.Get<T>();
        }
    }
}
