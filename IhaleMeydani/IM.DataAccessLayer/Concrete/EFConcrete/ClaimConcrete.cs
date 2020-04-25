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
    public class ClaimConcrete : BaseConcrete, IDataAccessDal<Claim>
    {
        public void Add(Claim entity)
        {
            DB.Claims.Add(entity);
            DB.SaveChanges();
        }

        public Claim Get(int id)
        {
            return DB.Claims.Find(id);
        }

        public List<Claim> GetAll()
        {
            return DB.Claims.ToList();
        }

        public IEnumerable<Claim> GetFilter(Expression<Func<Claim, bool>> expression)
        {
            return DB.Claims.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Claims.Remove(DB.Claims.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Claim t)
        {
            DB.Claims.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Claim t)
        {
            DB.Claims.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
