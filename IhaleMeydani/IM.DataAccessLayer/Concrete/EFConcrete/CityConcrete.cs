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
    public class CityConcrete : BaseConcrete, IDataAccessDal<city>
    {
        public void Add(city entity)
        {
            DB.cities.Add(entity);
            DB.SaveChanges();
        }

        public city Get(int id)
        {
            return DB.cities.Find(id);
        }

        public List<city> GetAll()
        {
            return DB.cities.ToList();
        }

        public IEnumerable<city> GetFilter(Expression<Func<city, bool>> expression)
        {
            return DB.cities.Where(expression);
        }

        public void Remove(int id)
        {
            DB.cities.Remove(DB.cities.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(city t)
        {
            DB.cities.Remove(t);
            DB.SaveChanges();
        }

        public void Update(city t)
        {
            DB.cities.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
