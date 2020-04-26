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
    public class NatificationConcrete : BaseConcrete, IDataAccessDal<natification>
    {
        public void Add(natification entity)
        {
            DB.natifications.Add(entity);
            DB.SaveChanges();
        }

        public natification Get(int id)
        {
            return DB.natifications.Find(id);
        }

        public List<natification> GetAll()
        {
            return DB.natifications.ToList();
        }

        public IEnumerable<natification> GetFilter(Expression<Func<natification, bool>> expression)
        {
            return DB.natifications.Where(expression);
        }

        public void Remove(int id)
        {
            DB.natifications.Remove(DB.natifications.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(natification t)
        {
            DB.natifications.Remove(t);
            DB.SaveChanges();
        }

        public void Update(natification t)
        {
            DB.natifications.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
