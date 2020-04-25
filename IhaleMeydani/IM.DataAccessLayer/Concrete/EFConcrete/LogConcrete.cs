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
    public class LogConcrete : BaseConcrete, IDataAccessDal<log>
    {
        public void Add(log entity)
        {
            DB.logs.Add(entity);
            DB.SaveChanges();
        }

        public log Get(int id)
        {
            return DB.logs.Find(id);
        }

        public List<log> GetAll()
        {
            return DB.logs.ToList();
        }

        public IEnumerable<log> GetFilter(Expression<Func<log, bool>> expression)
        {
            return DB.logs.Where(expression);
        }

        public void Remove(int id)
        {
            DB.logs.Remove(DB.logs.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(log t)
        {
            DB.logs.Remove(t);
            DB.SaveChanges();
        }

        public void Update(log t)
        {
            DB.logs.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
