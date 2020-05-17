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
            using (var transaction = DB.Database.BeginTransaction())
            {
                try
                {
                    medium media = new medium { image_name = t.image_name, image_path = t.image_path, image_title = t.image_title, image_subtitle = t.image_subtitle };
                    DB.media.Add(media);
                    DB.SaveChanges();
                    submit submit = new submit { media_id = media.id, submit_article = t.submit_article };
                    DB.submits.Add(submit);
                    DB.SaveChanges();
                    Post post = new Post { content_id = submit.submit_id, Post_date = DateTime.Now, users_id = t.users_id };
                    DB.Posts.Add(post);
                    DB.SaveChanges();
                    transaction.Commit();
                    return post.Post_id;
                }
                catch (Exception ex)
                {

                    var deneme = ex.Message;
                    transaction.Rollback();
                    return 0;
                }
            }
        }

        public int Multiupdate(PostModel t)
        {
            using (var transaction = DB.Database.BeginTransaction())
            {
                try
                {
                    medium media = new medium { id =t.id, image_name = t.image_name, image_path = t.image_path, image_title = t.image_title, image_subtitle = t.image_subtitle };
                    DB.media.Attach(media);
                    DB.Entry(media).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    submit submit = new submit { submit_id = t.submit_id, media_id = media.id, submit_article = t.submit_article };
                    DB.submits.Attach(submit);
                    DB.Entry(submit).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    Post post = new Post { Post_id = t.Post_id, content_id = t.content_id, Post_date = DateTime.Now, users_id = t.users_id };
                    DB.Posts.Attach(post);
                    DB.Entry(post).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                    transaction.Commit();
                    return post.Post_id;
                }
                catch (Exception ex)
                {

                    var deneme = ex.Message;
                    transaction.Rollback();
                    return 0;
                }
            }
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
