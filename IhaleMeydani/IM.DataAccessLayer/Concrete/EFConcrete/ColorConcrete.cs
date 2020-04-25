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
    public class ColorConcrete : BaseConcrete, IDataAccessDal<Color>
    {
        public void Add(Color entity)
        {
            DB.Colors.Add(entity);
            DB.SaveChanges();
        }

        public Color Get(int id)
        {
            return DB.Colors.Find(id);
        }

        public List<Color> GetAll()
        {
            return DB.Colors.ToList();
        }

        public IEnumerable<Color> GetFilter(Expression<Func<Color, bool>> expression)
        {
            return DB.Colors.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Colors.Remove(DB.Colors.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Color t)
        {
            DB.Colors.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Color t)
        {
            DB.Colors.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
