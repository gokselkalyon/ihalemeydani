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
    public class TagConcrete : BaseConcrete, IDataAccessDal<tag>
    {
        public void Add(tag entity)
        {
            DB.tags.Add(entity);
            DB.SaveChanges();
        }

        public tag Get(int id)
        {
            return DB.tags.Find(id);
        }

        public List<tag> GetAll()
        {
            return DB.tags.ToList();
        }

        public IEnumerable<tag> GetFilter(Expression<Func<tag, bool>> expression)
        {
            return DB.tags.Where(expression);
        }

        public void Remove(int id)
        {
            DB.tags.Remove(DB.tags.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(tag t)
        {
            DB.tags.Remove(t);
            DB.SaveChanges();
        }

        public void Update(tag t)
        {
            DB.tags.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
