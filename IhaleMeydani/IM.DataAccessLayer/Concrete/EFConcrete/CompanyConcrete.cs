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
    public class CompanyConcrete : BaseConcrete, IDataAccessDal<company>
    {
        public void Add(company entity)
        {
            DB.companies.Add(entity);
            DB.SaveChanges();
        }

        public company Get(int id)
        {
            return DB.companies.Find(id);
        }

        public List<company> GetAll()
        {
            return DB.companies.ToList();
        }

        public IEnumerable<company> GetFilter(Expression<Func<company, bool>> expression)
        {
            return DB.companies.Where(expression);
        }

        public void Remove(int id)
        {
            DB.companies.Remove(DB.companies.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(company t)
        {
            DB.companies.Remove(t);
            DB.SaveChanges();
        }

        public void Update(company t)
        {
            DB.companies.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
