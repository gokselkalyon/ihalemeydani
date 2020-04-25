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
    public class Company_TypeConcrete : BaseConcrete, IDataAccessDal<company_type>
    {
        public void Add(company_type entity)
        {
            DB.company_type.Add(entity);
            DB.SaveChanges();
        }

        public company_type Get(int id)
        {
            return DB.company_type.Find(id);
        }

        public List<company_type> GetAll()
        {
            return DB.company_type.ToList();
        }

        public IEnumerable<company_type> GetFilter(Expression<Func<company_type, bool>> expression)
        {
            return DB.company_type.Where(expression);
        }

        public void Remove(int id)
        {
            DB.company_type.Remove(DB.company_type.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(company_type t)
        {
            DB.company_type.Remove(t);
            DB.SaveChanges();
        }

        public void Update(company_type t)
        {
            DB.company_type.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
