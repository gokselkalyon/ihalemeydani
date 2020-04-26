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
    public class AuctionConcrete : BaseConcrete, IDataAccessDal<auction>
    {
        public void Add(auction entity)
        {
            DB.auctions.Add(entity);
            DB.SaveChanges();
        }

        public auction Get(int id)
        {
            return DB.auctions.Find(id);
        }

        public List<auction> GetAll()
        {
            return DB.auctions.ToList();
        }

        public IEnumerable<auction> GetFilter(Expression<Func<auction, bool>> expression)
        {
            return DB.auctions.Where(expression);
        }

        public void Remove(int id)
        {
            DB.auctions.Remove(DB.auctions.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(auction t)
        {
            DB.auctions.Remove(t);
            DB.SaveChanges();
        }

        public void Update(auction t)
        {
            DB.auctions.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
