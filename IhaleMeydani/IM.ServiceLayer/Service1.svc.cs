using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.Concrete;
using IM.BusinessLayer.DependencyResolver;
using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.EFConcrete;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IM.ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public List<log> GetData()
        {
            using (IDataBusinessService<log> _db = InstanceFactory.GetInstance<IDataBusinessService<log>>())
            {
                return _db.GetAll();
            }
        }
    }
}
