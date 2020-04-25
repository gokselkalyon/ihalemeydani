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
    public class E_invoiceConcrete : BaseConcrete, IDataAccessDal<E_INVOICE>
    {
        public void Add(E_INVOICE entity)
        {
            DB.E_INVOICE.Add(entity);
            DB.SaveChanges();
        }

        public E_INVOICE Get(int id)
        {
            return DB.E_INVOICE.Find(id);
        }

        public List<E_INVOICE> GetAll()
        {
            return DB.E_INVOICE.ToList();
        }

        public IEnumerable<E_INVOICE> GetFilter(Expression<Func<E_INVOICE, bool>> expression)
        {
            return DB.E_INVOICE.Where(expression);
        }

        public void Remove(int id)
        {
            DB.E_INVOICE.Remove(DB.E_INVOICE.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(E_INVOICE t)
        {
            DB.E_INVOICE.Remove(t);
            DB.SaveChanges();
        }

        public void Update(E_INVOICE t)
        {
            DB.E_INVOICE.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
