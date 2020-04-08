using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Abstract
{
    public interface IDataAccessDal<T> where T:class
    {
        void Add(T entity);
        T Get(int id);
        List<T> GetAll();
        IEnumerable<T> GetFilter(Expression<Func<T, bool>> expression);
        void Remove(int id);
        void RemoveAll(T t);
        void Update(T t);
    }
}
