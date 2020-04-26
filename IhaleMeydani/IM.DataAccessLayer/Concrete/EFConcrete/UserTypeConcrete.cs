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
    public class UserTypeConcrete : BaseConcrete, IDataAccessDal<UserType>
    {
        public void Add(UserType entity)
        {
            DB.UserTypes.Add(entity);
            DB.SaveChanges();
        }

        public UserType Get(int id)
        {
            return DB.UserTypes.Find(id);
        }

        public List<UserType> GetAll()
        {
            return DB.UserTypes.ToList();
        }

        public IEnumerable<UserType> GetFilter(Expression<Func<UserType, bool>> expression)
        {
            return DB.UserTypes.Where(expression);
        }

        public void Remove(int id)
        {
            DB.UserTypes.Remove(DB.UserTypes.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(UserType t)
        {
            DB.UserTypes.Remove(t);
            DB.SaveChanges();
        }

        public void Update(UserType t)
        {
            DB.UserTypes.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
