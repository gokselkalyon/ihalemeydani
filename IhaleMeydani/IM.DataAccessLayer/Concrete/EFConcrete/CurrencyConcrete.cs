using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.Basic;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class CurrencyConcrete : BaseConcrete, IDataAccessDal<CURRENCY>
    {
        public void Add(CURRENCY entity)
        {
            DB.CURRENCies.Add(entity);
            DB.SaveChanges();
        }

        public CURRENCY Get(int id)
        {
            return DB.CURRENCies.Find(id);
        }

        public List<CURRENCY> GetAll()
        {
            return DB.CURRENCies.ToList();
        }

        public IEnumerable<CURRENCY> GetFilter(Expression<Func<CURRENCY, bool>> expression)
        {
            return DB.CURRENCies.Where(expression);
        }

        public void Remove(int id)
        {
            DB.CURRENCies.Remove(DB.CURRENCies.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(CURRENCY t)
        {
            DB.CURRENCies.Remove(t);
            DB.SaveChanges();
        }

        public void Update(CURRENCY t)
        {
            DB.CURRENCies.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
