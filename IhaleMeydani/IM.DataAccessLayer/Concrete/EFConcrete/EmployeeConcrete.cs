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
    public class EmployeeConcrete : BaseConcrete, IDataAccessDal<employee>
    {
        public void Add(employee entity)
        {
            DB.employees.Add(entity);
            DB.SaveChanges();
        }

        public employee Get(int id)
        {
            return DB.employees.Find(id);
        }

        public List<employee> GetAll()
        {
            return DB.employees.ToList();
        }

        public IEnumerable<employee> GetFilter(Expression<Func<employee, bool>> expression)
        {
            return DB.employees.Where(expression);
        }

        public void Remove(int id)
        {
            DB.employees.Remove(DB.employees.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(employee t)
        {
            DB.employees.Remove(t);
            DB.SaveChanges();
        }

        public void Update(employee t)
        {
            DB.employees.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
