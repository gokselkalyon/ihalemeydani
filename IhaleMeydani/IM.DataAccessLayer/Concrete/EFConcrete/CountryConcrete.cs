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
    public class CountryConcrete : BaseConcrete, IDataAccessDal<country>
    {
        public void Add(country entity)
        {
            DB.countries.Add(entity);
            DB.SaveChanges();
        }

        public country Get(int id)
        {
            return DB.countries.Find(id);
        }

        public List<country> GetAll()
        {
            return DB.countries.ToList();
        }

        public IEnumerable<country> GetFilter(Expression<Func<country, bool>> expression)
        {
            return DB.countries.Where(expression);
        }

        public void Remove(int id)
        {
            DB.countries.Remove(DB.countries.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(country t)
        {
            DB.countries.Remove(t);
            DB.SaveChanges();
        }

        public void Update(country t)
        {
            DB.countries.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
