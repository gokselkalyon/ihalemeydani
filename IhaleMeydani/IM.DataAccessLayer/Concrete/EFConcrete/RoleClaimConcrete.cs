using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class RoleClaimConcrete:IDataAccessDal<RoleClaim>
    {
        IHALEDBEntities DB = new IHALEDBEntities();
        public void Add(RoleClaim entity)
        {
            DB.RoleClaims.Add(entity);
            DB.SaveChanges();
        }

        public RoleClaim Get(int id)
        {
            return DB.RoleClaims.Find(id);
        }

        public List<RoleClaim> GetAll()
        {
            return DB.RoleClaims.ToList();
        }

        public IEnumerable<RoleClaim> GetFilter(Expression<Func<RoleClaim, bool>> expression)
        {
            return DB.RoleClaims.Where(expression);
        }

        public void Remove(int id)
        {
            DB.RoleClaims.Remove(DB.RoleClaims.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(RoleClaim t)
        {
            DB.RoleClaims.Remove(t);
            DB.SaveChanges();
        }

        public void Update(RoleClaim t)
        {
            DB.RoleClaims.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
