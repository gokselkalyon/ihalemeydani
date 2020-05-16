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
    public class PostConcrete : BaseConcrete, IDataAccessDal<Post>, IDataBaseQuery<PostModel>
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

        public int MultiAdded(PostModel t)
        {
            throw new NotImplementedException();
        }

        public int Multiupdate(PostModel t)
        {
            throw new NotImplementedException();
        }

        public List<PostModel> QueryList()
        {
            return DB.Database.SqlQuery<PostModel>("select * from postview").ToList();
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
