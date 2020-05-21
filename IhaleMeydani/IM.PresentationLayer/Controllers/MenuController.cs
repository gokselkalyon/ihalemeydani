using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    //[RoutePrefix("Menü")]
    public class MenuController : BaseController
    {
        List<MenuModel> menus = new List<MenuModel>();
        // GET: Menu
        [Route("Menüler")]
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GetMenus()
        {
            menus.Clear();

            var _menus = IhaleServiceClient.GetMenus().ToList();
            foreach (var menu in _menus)
            {
                menus.Add(new MenuModel
                {
                    Id = menu.Id,
                    Name = menu.Name,
                    Description = menu.Description,
                    Url = menu.Url,
                    IconName = IhaleServiceClient.IconName(menu.IconId),
                    SubMenu = IhaleServiceClient.GetMenu(menu.MenuId.Value).Name
                });
            }

            return PartialView(menus);
        }
    }
}