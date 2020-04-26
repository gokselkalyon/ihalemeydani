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
    public class AuctionUserConcrete : BaseConcrete, IDataAccessDal<actionuser>
    {
        public void Add(actionuser entity)
        {
            DB.actionusers.Add(entity);
            DB.SaveChanges();
        }

        public actionuser Get(int id)
        {
            return DB.actionusers.Find(id);
        }

        public List<actionuser> GetAll()
        {
            return DB.actionusers.ToList();
        }

        public IEnumerable<actionuser> GetFilter(Expression<Func<actionuser, bool>> expression)
        {
            return DB.actionusers.Where(expression);
        }

        public void Remove(int id)
        {
            DB.actionusers.Remove(DB.actionusers.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(actionuser t)
        {
            DB.actionusers.Remove(t);
            DB.SaveChanges();
        }

        public void Update(actionuser t)
        {
            DB.actionusers.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
