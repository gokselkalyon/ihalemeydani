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
    public class LogInfoesConcrete:BaseConcrete, IDataAccessDal<LogInfo>
    {
        public void Add(LogInfo entity)
        {
            DB.LogInfoes.Add(entity);
            DB.SaveChanges();
        }

        public LogInfo Get(int id)
        {
            return DB.LogInfoes.Find(id);
        }

        public List<LogInfo> GetAll()
        {
            return DB.LogInfoes.ToList();
        }

        public IEnumerable<LogInfo> GetFilter(Expression<Func<LogInfo, bool>> expression)
        {
            return DB.LogInfoes.Where(expression);
        }

        public void Remove(int id)
        {
            DB.LogInfoes.Remove(DB.LogInfoes.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(LogInfo t)
        {
            DB.LogInfoes.Remove(t);
            DB.SaveChanges();
        }

        public void Update(LogInfo t)
        {
            DB.LogInfoes.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
