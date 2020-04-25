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
    public class DiscountcartConcrete : BaseConcrete, IDataAccessDal<discountcart>
    {
        public void Add(discountcart entity)
        {
            DB.discountcarts.Add(entity);
            DB.SaveChanges();
        }

        public discountcart Get(int id)
        {
            return DB.discountcarts.Find(id);
        }

        public List<discountcart> GetAll()
        {
            return DB.discountcarts.ToList();
        }

        public IEnumerable<discountcart> GetFilter(Expression<Func<discountcart, bool>> expression)
        {
            return DB.discountcarts.Where(expression);
        }

        public void Remove(int id)
        {
            DB.discountcarts.Remove(DB.discountcarts.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(discountcart t)
        {
            DB.discountcarts.Remove(t);
            DB.SaveChanges();
        }

        public void Update(discountcart t)
        {
            DB.discountcarts.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
