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
    public class Employee_PositionConcrete : BaseConcrete, IDataAccessDal<employee_position>
    {
        public void Add(employee_position entity)
        {
            DB.employee_position.Add(entity);
            DB.SaveChanges();
        }

        public employee_position Get(int id)
        {
            return DB.employee_position.Find(id);
        }

        public List<employee_position> GetAll()
        {
            return DB.employee_position.ToList();
        }

        public IEnumerable<employee_position> GetFilter(Expression<Func<employee_position, bool>> expression)
        {
            return DB.employee_position.Where(expression);
        }

        public void Remove(int id)
        {
            DB.employee_position.Remove(DB.employee_position.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(employee_position t)
        {
            DB.employee_position.Remove(t);
            DB.SaveChanges();
        }

        public void Update(employee_position t)
        {
            DB.employee_position.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
