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
    public class Payment_PlanConcrete : BaseConcrete, IDataAccessDal<payment_plan>
    {
        public void Add(payment_plan entity)
        {
            DB.payment_plan.Add(entity);
            DB.SaveChanges();
        }

        public payment_plan Get(int id)
        {
            return DB.payment_plan.Find(id);
        }

        public List<payment_plan> GetAll()
        {
            return DB.payment_plan.ToList();
        }

        public IEnumerable<payment_plan> GetFilter(Expression<Func<payment_plan, bool>> expression)
        {
            return DB.payment_plan.Where(expression);
        }

        public void Remove(int id)
        {
            DB.payment_plan.Remove(DB.payment_plan.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(payment_plan t)
        {
            DB.payment_plan.Remove(t);
            DB.SaveChanges();
        }

        public void Update(payment_plan t)
        {
            DB.payment_plan.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
