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
    public class TitleConcrete : BaseConcrete, IDataAccessDal<title>
    {
        public void Add(title entity)
        {
            DB.titles.Add(entity);
            DB.SaveChanges();
        }

        public title Get(int id)
        {
            return DB.titles.Find(id);
        }

        public List<title> GetAll()
        {
            return DB.titles.ToList();
        }

        public IEnumerable<title> GetFilter(Expression<Func<title, bool>> expression)
        {
            return DB.titles.Where(expression);
        }

        public void Remove(int id)
        {
            DB.titles.Remove(DB.titles.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(title t)
        {
            DB.titles.Remove(t);
            DB.SaveChanges();
        }

        public void Update(title t)
        {
            DB.titles.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
