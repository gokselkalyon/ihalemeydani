using IM.DataAccessLayer.Abstract;
using IM.DataAccessLayer.Concrete.Basic;
using IM.DataLayer;
using IM.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class AuctionConcrete : BaseConcrete, IDataAccessDal<auction>,IDataBaseQuery<UserAuctionModel>
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

        public int MultiAdded(UserAuctionModel t)
        {
            using (var transaction = DB.Database.BeginTransaction())
            {
                try
                {
                    
                    AMOUNT_OF_INCREASE aoi = new AMOUNT_OF_INCREASE
                    {
                        ID = t.AoFID,
                        DATE_OF_UPDATE = t.DATE_OF_UPDATE,
                        INCREASE_PRICE = t.INCREASE_PRICE,
                        MAX_PRICE = t.MAX_PRICE,
                        MIN_PRICE = t.MIN_PRICE,
                        CURRENCY_ID = t.CURRENCY_ID,
                    };
                    DB.AMOUNT_OF_INCREASE.Add(aoi);
                    DB.SaveChanges();
                    auction auction = new auction
                    {
                        ACUTION_DATE = t.ACUTION_DATE,
                        ACUTION_SALES_TIME = t.ACUTION_SALES_TIME,
                        AMOUNT_OF_INCREASE_ID = aoi.ID,
                        DATE_OF_UPDATE = DateTime.Now,
                        PRODUCT_ID = t.userproductID,
                        USER_ID = t.userid,
                    };
                    DB.auctions.Add(auction);
                    DB.SaveChanges();
                    transaction.Commit();
                    return auction.ID;
                }
                catch (Exception ex)
                {
                    var excep = ex.Message;
                    transaction.Rollback();
                    return 0;
                }
            }
        }

        public int Multiupdate(UserAuctionModel t)
        {
            using (var transaction = DB.Database.BeginTransaction())
            {
                try
                {
                   
                    AMOUNT_OF_INCREASE aoi = new AMOUNT_OF_INCREASE
                    {
                        ID = t.AoFID,
                        DATE_OF_UPDATE = t.DATE_OF_UPDATE,
                        INCREASE_PRICE = t.INCREASE_PRICE,
                        MAX_PRICE = t.MAX_PRICE,
                        MIN_PRICE = t.MIN_PRICE,
                        CURRENCY_ID = t.CURRENCY_ID,
                        UPDATED_PERSON_ID = t.userproductID
                    };
                    DB.AMOUNT_OF_INCREASE.Attach(aoi);
                    DB.Entry(aoi).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    auction auction = new auction
                    {
                        ACUTION_DATE = t.ACUTION_DATE,
                        ACUTION_SALES_TIME = t.ACUTION_SALES_TIME,
                        AMOUNT_OF_INCREASE_ID = aoi.ID,
                        DATE_OF_UPDATE = DateTime.Now,
                        PRODUCT_ID = t.userproductID,
                        USER_ID = t.userid,
                    };
                    DB.auctions.Attach(auction);
                    DB.Entry(auction).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    transaction.Commit();
                    return auction.ID;
                }
                catch (Exception ex)
                {
                    var excep = ex.Message;
                    transaction.Rollback();
                    return 0;
                }
            }
        }

        public List<UserAuctionModel> QueryList()
        {
            return DB.Database.SqlQuery<UserAuctionModel>("select * from userauctionview").ToList();
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
