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
    public class SubmitConcrete : BaseConcrete, IDataAccessDal<submit>
    {
        public void Add(submit entity)
        {
            DB.submits.Add(entity);
            DB.SaveChanges();
        }

        public submit Get(int id)
        {
            return DB.submits.Find(id);
        }

        public List<submit> GetAll()
        {
            return DB.submits.ToList();
        }

        public IEnumerable<submit> GetFilter(Expression<Func<submit, bool>> expression)
        {
            return DB.submits.Where(expression);
        }

        public void Remove(int id)
        {
            DB.submits.Remove(DB.submits.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(submit t)
        {
            DB.submits.Remove(t);
            DB.SaveChanges();
        }

        public void Update(submit t)
        {
            DB.submits.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
