using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Tools
{
    public class DatabaseSingleton
    {
        public readonly static IHALEDBEntities _db;

        public static IHALEDBEntities db => _db ?? new IHALEDBEntities();
    }
}
