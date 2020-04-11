using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IM.DataAccessLayer.Concrete.EFConcrete
{
    public class MediumConcrete:IDataAccessDal<medium>
    {
        IHALEDBEntities DB = new IHALEDBEntities();
        public void Add(medium entity)
        {
            DB.media.Add(entity);
            DB.SaveChanges();
        }

        public medium Get(int id)
        {
            return DB.media.Find(id);
        }

        public List<medium> GetAll()
        {
            return DB.media.ToList();
        }

        public IEnumerable<medium> GetFilter(Expression<Func<medium, bool>> expression)
        {
            return DB.media.Where(expression);
        }

        public void Remove(int id)
        {
            DB.media.Remove(DB.media.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(medium t)
        {
            DB.media.Remove(t);
            DB.SaveChanges();
        }

        public void Update(medium t)
        {
            DB.media.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
