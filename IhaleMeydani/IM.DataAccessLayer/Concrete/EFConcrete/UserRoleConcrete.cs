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
    public class UserRoleConcrete : BaseConcrete, IDataAccessDal<UserRole>
    {
        public void Add(UserRole entity)
        {
            DB.UserRoles.Add(entity);
            DB.SaveChanges();
        }

        public UserRole Get(int id)
        {
            return DB.UserRoles.Find(id);
        }

        public List<UserRole> GetAll()
        {
            return DB.UserRoles.ToList();
        }

        public IEnumerable<UserRole> GetFilter(Expression<Func<UserRole, bool>> expression)
        {
            return DB.UserRoles.Where(expression);
        }

        public void Remove(int id)
        {
            DB.UserRoles.Remove(DB.UserRoles.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(UserRole t)
        {
            DB.UserRoles.Remove(t);
            DB.SaveChanges();
        }

        public void Update(UserRole t)
        {
            DB.UserRoles.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
