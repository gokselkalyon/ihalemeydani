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
    public class PostConcrete : BaseConcrete, IDataAccessDal<Post>
    {
        public void Add(Post entity)
        {
            DB.Posts.Add(entity);
            DB.SaveChanges();
        }

        public Post Get(int id)
        {
            return DB.Posts.Find(id);
        }

        public List<Post> GetAll()
        {
            return DB.Posts.ToList();
        }

        public IEnumerable<Post> GetFilter(Expression<Func<Post, bool>> expression)
        {
            return DB.Posts.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Posts.Remove(DB.Posts.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Post t)
        {
            DB.Posts.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Post t)
        {
            DB.Posts.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
