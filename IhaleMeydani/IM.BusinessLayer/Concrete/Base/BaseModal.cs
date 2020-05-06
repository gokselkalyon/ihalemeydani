using IM.DataAccessLayer.Tools;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete.Base
{
    public class BaseModal
    {
        public IHALEDBEntities db = DatabaseSingleton.GetInstance();
    }
}
