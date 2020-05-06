using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.DependencyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.ServiceLayer
{
    public class BaseService
    {
        public static IDataBusinessService<T> Create<T>() where T:class,new()
        {
          return  InstanceFactory.GetInstance<IDataBusinessService<T>>();
        }
    }
}