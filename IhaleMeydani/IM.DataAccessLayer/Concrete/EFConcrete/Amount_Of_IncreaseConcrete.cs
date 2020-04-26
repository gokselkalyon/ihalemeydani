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
    public class Amount_Of_IncreaseConcrete:BaseConcrete,IDataAccessDal<AMOUNT_OF_INCREASE>
    {
        public void Add(AMOUNT_OF_INCREASE entity)
        {
            DB.AMOUNT_OF_INCREASE.Add(entity);
            DB.SaveChanges();
        }

        public AMOUNT_OF_INCREASE Get(int id)
        {
            return DB.AMOUNT_OF_INCREASE.Find(id);
        }

        public List<AMOUNT_OF_INCREASE> GetAll()
        {
            return DB.AMOUNT_OF_INCREASE.ToList();
        }

        public IEnumerable<AMOUNT_OF_INCREASE> GetFilter(Expression<Func<AMOUNT_OF_INCREASE, bool>> expression)
        {
            return DB.AMOUNT_OF_INCREASE.Where(expression);
        }

        public void Remove(int id)
        {
            DB.AMOUNT_OF_INCREASE.Remove(DB.AMOUNT_OF_INCREASE.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(AMOUNT_OF_INCREASE t)
        {
            DB.AMOUNT_OF_INCREASE.Remove(t);
            DB.SaveChanges();
        }

        public void Update(AMOUNT_OF_INCREASE t)
        {
            DB.AMOUNT_OF_INCREASE.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
