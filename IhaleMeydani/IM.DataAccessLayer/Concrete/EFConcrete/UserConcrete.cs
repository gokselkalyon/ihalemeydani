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
    public class UserConcrete : BaseConcrete, IDataAccessDal<User>
    {
        public void Add(User entity)
        {
            DB.Users.Add(entity);
            DB.SaveChanges();
        }

        public User Get(int id)
        {
            return DB.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return DB.Users.ToList();
        }

        public IEnumerable<User> GetFilter(Expression<Func<User, bool>> expression)
        {
            return DB.Users.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Users.Remove(DB.Users.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(User t)
        {
            DB.Users.Remove(t);
            DB.SaveChanges();
        }

        public void Update(User t)
        {
            DB.Users.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
