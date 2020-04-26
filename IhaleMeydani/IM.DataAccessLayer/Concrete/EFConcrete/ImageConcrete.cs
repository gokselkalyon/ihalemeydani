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
    public class ImageConcrete : BaseConcrete, IDataAccessDal<Image>
    {
        public void Add(Image entity)
        {
            DB.Images.Add(entity);
            DB.SaveChanges();
        }

        public Image Get(int id)
        {
            return DB.Images.Find(id);
        }

        public List<Image> GetAll()
        {
            return DB.Images.ToList();
        }

        public IEnumerable<Image> GetFilter(Expression<Func<Image, bool>> expression)
        {
            return DB.Images.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Images.Remove(DB.Images.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Image t)
        {
            DB.Images.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Image t)
        {
            DB.Images.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
