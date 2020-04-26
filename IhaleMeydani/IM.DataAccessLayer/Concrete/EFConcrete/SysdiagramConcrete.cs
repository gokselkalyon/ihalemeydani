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
    public class SysdiagramConcrete : BaseConcrete, IDataAccessDal<sysdiagram>
    {
        public void Add(sysdiagram entity)
        {
            DB.sysdiagrams.Add(entity);
            DB.SaveChanges();
        }

        public sysdiagram Get(int id)
        {
            return DB.sysdiagrams.Find(id);
        }

        public List<sysdiagram> GetAll()
        {
            return DB.sysdiagrams.ToList();
        }

        public IEnumerable<sysdiagram> GetFilter(Expression<Func<sysdiagram, bool>> expression)
        {
            return DB.sysdiagrams.Where(expression);
        }

        public void Remove(int id)
        {
            DB.sysdiagrams.Remove(DB.sysdiagrams.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(sysdiagram t)
        {
            DB.sysdiagrams.Remove(t);
            DB.SaveChanges();
        }

        public void Update(sysdiagram t)
        {
            DB.sysdiagrams.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
