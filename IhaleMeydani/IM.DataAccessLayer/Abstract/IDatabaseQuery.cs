using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Abstract
{
    public interface IDataBaseQuery<T> where T:class,new()
    {
        List<T> QueryList(string query);
    }
}
