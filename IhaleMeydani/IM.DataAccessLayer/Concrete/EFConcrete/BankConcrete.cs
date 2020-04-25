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
    public class BankConcrete : BaseConcrete, IDataAccessDal<bank>
    {
        public void Add(bank entity)
        {
            DB.banks.Add(entity);
            DB.SaveChanges();
        }

        public bank Get(int id)
        {
            return DB.banks.Find(id);
        }

        public List<bank> GetAll()
        {
            return DB.banks.ToList();
        }

        public IEnumerable<bank> GetFilter(Expression<Func<bank, bool>> expression)
        {
            return DB.banks.Where(expression);
        }

        public void Remove(int id)
        {
            DB.banks.Remove(DB.banks.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(bank t)
        {
            DB.banks.Remove(t);
            DB.SaveChanges();
        }

        public void Update(bank t)
        {
            DB.banks.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
