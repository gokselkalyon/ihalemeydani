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
    public class PrivateAuctionConcrete : BaseConcrete, IDataAccessDal<private_auction>
    {
        public void Add(private_auction entity)
        {
            DB.private_auction.Add(entity);
            DB.SaveChanges();
        }

        public private_auction Get(int id)
        {
            return DB.private_auction.Find(id);
        }

        public List<private_auction> GetAll()
        {
            return DB.private_auction.ToList();
        }

        public IEnumerable<private_auction> GetFilter(Expression<Func<private_auction, bool>> expression)
        {
            return DB.private_auction.Where(expression);
        }

        public void Remove(int id)
        {
            DB.private_auction.Remove(DB.private_auction.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(private_auction t)
        {
            DB.private_auction.Remove(t);
            DB.SaveChanges();
        }

        public void Update(private_auction t)
        {
            DB.private_auction.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
