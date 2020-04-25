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
    public class E_Invoice_TypeConcrete : BaseConcrete, IDataAccessDal<E_invoice_type>
    {
        public void Add(E_invoice_type entity)
        {
            DB.E_invoice_type.Add(entity);
            DB.SaveChanges();
        }

        public E_invoice_type Get(int id)
        {
            return DB.E_invoice_type.Find(id);
        }

        public List<E_invoice_type> GetAll()
        {
            return DB.E_invoice_type.ToList();
        }

        public IEnumerable<E_invoice_type> GetFilter(Expression<Func<E_invoice_type, bool>> expression)
        {
            return DB.E_invoice_type.Where(expression);
        }

        public void Remove(int id)
        {
            DB.E_invoice_type.Remove(DB.E_invoice_type.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(E_invoice_type t)
        {
            DB.E_invoice_type.Remove(t);
            DB.SaveChanges();
        }

        public void Update(E_invoice_type t)
        {
            DB.E_invoice_type.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
