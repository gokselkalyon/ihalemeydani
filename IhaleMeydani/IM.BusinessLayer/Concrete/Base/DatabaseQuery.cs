using IM.BusinessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete.Base
{
    public class DatabaseQuery : BaseModal, IDatabaseQuery
    {
        public List<TT> QueryList<TT>(string query)
        {
            return db.Database.SqlQuery<TT>(query).ToList();
        }
    }
}
