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
    public class Tax_AdministrationConcrete : BaseConcrete, IDataAccessDal<Tax_Administration>
    {
        public void Add(Tax_Administration entity)
        {
            DB.Tax_Administration.Add(entity);
            DB.SaveChanges();
        }

        public Tax_Administration Get(int id)
        {
            return DB.Tax_Administration.Find(id);
        }

        public List<Tax_Administration> GetAll()
        {
            return DB.Tax_Administration.ToList();
        }

        public IEnumerable<Tax_Administration> GetFilter(Expression<Func<Tax_Administration, bool>> expression)
        {
            return DB.Tax_Administration.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Tax_Administration.Remove(DB.Tax_Administration.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Tax_Administration t)
        {
            DB.Tax_Administration.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Tax_Administration t)
        {
            DB.Tax_Administration.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
