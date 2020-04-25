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
    public class Tag_PostConcrete : BaseConcrete, IDataAccessDal<tag_post>
    {
        public void Add(tag_post entity)
        {
            DB.tag_post.Add(entity);
            DB.SaveChanges();
        }

        public tag_post Get(int id)
        {
            return DB.tag_post.Find(id);
        }

        public List<tag_post> GetAll()
        {
            return DB.tag_post.ToList();
        }

        public IEnumerable<tag_post> GetFilter(Expression<Func<tag_post, bool>> expression)
        {
            return DB.tag_post.Where(expression);
        }

        public void Remove(int id)
        {
            DB.tag_post.Remove(DB.tag_post.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(tag_post t)
        {
            DB.tag_post.Remove(t);
            DB.SaveChanges();
        }

        public void Update(tag_post t)
        {
            DB.tag_post.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
