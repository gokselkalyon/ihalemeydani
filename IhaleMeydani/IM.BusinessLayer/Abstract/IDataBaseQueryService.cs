using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Abstract
{
    public interface IDataBaseQueryService<T> where T : class
    {
        List<T> QueryList();
        int Multiupdate(T t);
        int MultiAdded(T t);
        /* örnek userproductmodel içerisinde 5 farklı tablo barındırıyor
         * bunları gerekli tablolara eklemek amaçlı kullanacağı*/
    }
}
