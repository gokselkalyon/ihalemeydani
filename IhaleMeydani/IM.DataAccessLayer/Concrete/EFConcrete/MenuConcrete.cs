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
        public int MainCount = 0;
        StringBuilder sb = new StringBuilder();
        public void Add(Menu entity)
        {
            DB.Menus.Add(entity);
            DB.SaveChanges();
        }

        public List<Menu> SubMenu(int id)
        {
            return DB.Menus.Where(x => x.MenuId == id).ToList();
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
        public StringBuilder MainMenu()
        {
            sb.Clear();
            sb.Append("<ul class='nav navbar-nav navbar-left'>");

            var _MainMenu = GetFilter(x => x.MenuId == 0);
            foreach (var mainmenu in _MainMenu)
            {
                MainCount++;
                sb.Append("<li class='has-dropdown'><a data-toggle='dropdown' class='dropdown-toggle' href='" + mainmenu.Name + "'>" + mainmenu.Name + "</a>");
                SubCategory(mainmenu.Id);
                sb.Append("</li>");
            }
            sb.Append("</ul>");
            return sb;
        }
        private void SubCategory(int id)
        {
            int say = SubMenu(id).Count;
            if (say > 0)
            {
                var _submenu = SubMenu(id);
                sb.Append("<ul class='dropdown-menu'>");
                foreach (Menu submenus in _submenu)
                {
                    sb.Append("<li><a href='" + submenus.Name + "'>" + submenus.Name + "</a>");
                    SubCategory(submenus.Id);//Eger alt kategorinin de alt kategorisi var ise Altkategori metoduna gönderiyoruz
                    sb.Append("</li>");
                }
                sb.Append("</ul>");
            }
        }
    }
}
