using IM.DataAccessLayer.Tools;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.Basic
{
    public class BaseConcrete
    {
        public IHALEDBEntities DB = DatabaseSingleton.GetInstance();
    }
}
