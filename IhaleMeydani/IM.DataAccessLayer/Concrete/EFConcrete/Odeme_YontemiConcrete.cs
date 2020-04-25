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
    public class Odeme_YontemiConcrete : BaseConcrete, IDataAccessDal<odeme_yontemi>
    {
        public void Add(odeme_yontemi entity)
        {
            DB.odeme_yontemi.Add(entity);
            DB.SaveChanges();
        }

        public odeme_yontemi Get(int id)
        {
            return DB.odeme_yontemi.Find(id);
        }

        public List<odeme_yontemi> GetAll()
        {
            return DB.odeme_yontemi.ToList();
        }

        public IEnumerable<odeme_yontemi> GetFilter(Expression<Func<odeme_yontemi, bool>> expression)
        {
            return DB.odeme_yontemi.Where(expression);
        }

        public void Remove(int id)
        {
            DB.odeme_yontemi.Remove(DB.odeme_yontemi.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(odeme_yontemi t)
        {
            DB.odeme_yontemi.Remove(t);
            DB.SaveChanges();
        }

        public void Update(odeme_yontemi t)
        {
            DB.odeme_yontemi.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
