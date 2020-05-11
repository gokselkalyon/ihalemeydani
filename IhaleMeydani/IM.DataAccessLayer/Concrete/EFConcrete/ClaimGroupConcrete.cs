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
    public class ClaimGroupConcrete : BaseConcrete, IDataAccessDal<ClaimGroup>
    {
        public void Add(ClaimGroup entity)
        {
            DB.ClaimGroups.Add(entity);
            DB.SaveChanges();
        }

        public ClaimGroup Get(int id)
        {
            return DB.ClaimGroups.Find(id);
        }

        public List<ClaimGroup> GetAll()
        {
            return DB.ClaimGroups.ToList();
        }

        public IEnumerable<ClaimGroup> GetFilter(Expression<Func<ClaimGroup, bool>> expression)
        {
            return DB.ClaimGroups.Where(expression);
        }

        public void Remove(int id)
        {
            DB.ClaimGroups.Remove(DB.ClaimGroups.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(ClaimGroup t)
        {
            DB.ClaimGroups.Remove(t);
            DB.SaveChanges();
        }

        public void Update(ClaimGroup t)
        {
            DB.ClaimGroups.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
