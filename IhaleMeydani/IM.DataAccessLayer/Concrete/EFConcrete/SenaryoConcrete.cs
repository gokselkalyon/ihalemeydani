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
    public class SenaryoConcrete : BaseConcrete, IDataAccessDal<senaryo>
    {
        public void Add(senaryo entity)
        {
            DB.senaryoes.Add(entity);
            DB.SaveChanges();
        }

        public senaryo Get(int id)
        {
            return DB.senaryoes.Find(id);
        }

        public List<senaryo> GetAll()
        {
            return DB.senaryoes.ToList();
        }

        public IEnumerable<senaryo> GetFilter(Expression<Func<senaryo, bool>> expression)
        {
            return DB.senaryoes.Where(expression);
        }

        public void Remove(int id)
        {
            DB.senaryoes.Remove(DB.senaryoes.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(senaryo t)
        {
            DB.senaryoes.Remove(t);
            DB.SaveChanges();
        }

        public void Update(senaryo t)
        {
            DB.senaryoes.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
