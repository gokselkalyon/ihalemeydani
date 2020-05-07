
using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.Basic;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.Base
{
    public class DatabaseQuery : BaseConcrete, IDatabaseQuery
    {
        public  List<TT> QueryList<TT>(string query)
        {
            return DB.Database.SqlQuery<TT>(query).ToList();
        }
    }
}
