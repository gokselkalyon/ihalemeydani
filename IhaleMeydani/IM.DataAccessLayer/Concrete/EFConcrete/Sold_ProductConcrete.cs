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
    public class Sold_ProductConcrete : BaseConcrete, IDataAccessDal<SOLD_PRODUCT>
    {
        public void Add(SOLD_PRODUCT entity)
        {
            DB.SOLD_PRODUCT.Add(entity);
            DB.SaveChanges();
        }

        public SOLD_PRODUCT Get(int id)
        {
            return DB.SOLD_PRODUCT.Find(id);
        }

        public List<SOLD_PRODUCT> GetAll()
        {
            return DB.SOLD_PRODUCT.ToList();
        }

        public IEnumerable<SOLD_PRODUCT> GetFilter(Expression<Func<SOLD_PRODUCT, bool>> expression)
        {
            return DB.SOLD_PRODUCT.Where(expression);
        }

        public void Remove(int id)
        {
            DB.SOLD_PRODUCT.Remove(DB.SOLD_PRODUCT.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(SOLD_PRODUCT t)
        {
            DB.SOLD_PRODUCT.Remove(t);
            DB.SaveChanges();
        }

        public void Update(SOLD_PRODUCT t)
        {
            DB.SOLD_PRODUCT.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
