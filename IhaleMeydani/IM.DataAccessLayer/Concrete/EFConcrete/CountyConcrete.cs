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
    public class CountyConcrete: BaseConcrete,IDataAccessDal<county>
    {
        public void Add(county entity)
        {
            DB.counties.Add(entity);
            DB.SaveChanges();
        }

        public county Get(int id)
        {
            return DB.counties.Find(id);
        }

        public List<county> GetAll()
        {
            return DB.counties.ToList();
        }

        public IEnumerable<county> GetFilter(Expression<Func<county, bool>> expression)
        {
            return DB.counties.Where(expression);
        }

        public void Remove(int id)
        {
            DB.counties.Remove(DB.counties.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(county t)
        {
            DB.counties.Remove(t);
            DB.SaveChanges();
        }

        public void Update(county t)
        {
            DB.counties.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
