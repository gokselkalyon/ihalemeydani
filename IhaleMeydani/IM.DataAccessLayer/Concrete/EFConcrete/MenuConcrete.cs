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
    public class MenuConcrete : BaseConcrete, IDataAccessDal<Menu>
    {
        public void Add(Menu entity)
        {
            DB.Menus.Add(entity);
            DB.SaveChanges();
        }

        public Menu Get(int id)
        {
            return DB.Menus.Find(id);
        }

        public List<Menu> GetAll()
        {
            return DB.Menus.ToList();
        }

        public IEnumerable<Menu> GetFilter(Expression<Func<Menu, bool>> expression)
        {
            return DB.Menus.Where(expression);
        }

        public void Remove(int id)
        {
            DB.Menus.Remove(DB.Menus.Find(id));
            DB.SaveChanges();
        }

        public void RemoveAll(Menu t)
        {
            DB.Menus.Remove(t);
            DB.SaveChanges();
        }

        public void Update(Menu t)
        {
            DB.Menus.Attach(t);
            DB.Entry(t).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
