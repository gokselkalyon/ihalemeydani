using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Tools
{
    public static class DatabaseSingleton
    {
        private readonly static IHALEDBEntities _db;

        public static IHALEDBEntities GetInstance()
        {
            return _db ?? new IHALEDBEntities();
        }
    }
}
