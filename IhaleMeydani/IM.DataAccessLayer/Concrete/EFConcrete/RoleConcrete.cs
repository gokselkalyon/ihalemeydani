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
    public class RoleConcrete : BaseConcrete, IDataAccessDal<Role>
    {
        public void Add(Role entity)
        {
            DB.Roles.Add(entity);
            DB.SaveChanges();
        }

        public Role Get(int id)
        {
            return DB.Roles.Find(id);
        }

        public List<Role> GetAll()
        {
            return DB.Roles.ToList();
        }

        public IEnumerable<Role> GetFilter(Expression<Func<Role, bool>> expression)
        {
            return DB.Roles.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Roles.Remove(DB.Roles.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Role t)
        {
            DB.Roles.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Role t)
        {
            DB.Roles.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
