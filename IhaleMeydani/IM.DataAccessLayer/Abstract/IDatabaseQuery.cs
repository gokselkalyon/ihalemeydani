using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Abstract
{
    public interface IDataBaseQuery<T> where T:class,new()
    {
        List<T> QueryList();
        int MultiAdded(T t);
        int Multiupdate(T t);
        /* örnek userproductmodel içerisinde 5 farklı tablo barındırıyor
         * bunları gerekli tablolara eklemek amaçlı kullanacağı*/
    }
}
