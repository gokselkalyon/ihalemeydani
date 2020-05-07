using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Abstract
{
    public interface IDatabaseQuery
    {
        List<TT> QueryList<TT>(string query);
    }
}
