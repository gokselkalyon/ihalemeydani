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
    public class UserProductConcrete : BaseConcrete, IDataAccessDal<userproduct>
    {
        public void Add(userproduct entity)
        {
            DB.userproducts.Add(entity);
            DB.SaveChanges();
        }

        public userproduct Get(int id)
        {
            return DB.userproducts.Find(id);
        }

        public List<userproduct> GetAll()
        {
            return DB.userproducts.ToList();
        }

        public IEnumerable<userproduct> GetFilter(Expression<Func<userproduct, bool>> expression)
        {
            return DB.userproducts.Where(expression);
        }

        public void Remove(int id)
        {
            DB.userproducts.Remove(DB.userproducts.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(userproduct t)
        {
            DB.userproducts.Remove(t);
            DB.SaveChanges();
        }

        public void Update(userproduct t)
        {
            DB.userproducts.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
