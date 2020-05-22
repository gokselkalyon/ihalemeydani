using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using I = IM.PresentationLayer.IhaleWCFService;

namespace IM.PresentationLayer.Controllers
{
    //[RoutePrefix("Menü")]
    public class MenuController : BaseController
    {
        List<SelectListItem> _Icons = new List<SelectListItem>();

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
                    IconName = (menu.IconId.Value == 0) ? "İcon Yok" : IhaleServiceClient.IconName(menu.IconId),
                    SubMenu = (menu.MenuId.Value == 0) ? "Üst Menü Yok" : IhaleServiceClient.GetMenu(menu.MenuId.Value).Name
                });
            }

            return PartialView(menus);
        }

        [HttpPost]
        [Route("RemoveMenu")]
        public JsonResult RemoveMenu(int id)
        {
            IhaleServiceClient.RemoveMenu(id);

            jsonResultModel.Title = "Silme İşlemi";
            jsonResultModel.Description = "Menü Silme İşlemi Başarıyla Gerçekleşti";
            jsonResultModel.Icon = "success";

            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
        public PartialViewResult MenuAdd()
        {
            SelectListItems.Clear();
            _Icons.Clear();

            var _menus = IhaleServiceClient.GetMenus().Select(x => new { x.Id, x.Name }).ToList();

            foreach (var item in _menus)
            {
                SelectListItems.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name
                });
            }

            var Icons = IhaleServiceClient.GetIcons().Select(x => new { x.Id, x.Name }).ToList();

            foreach (var item in Icons)
            {
                _Icons.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name
                });
            }


            TempData["Icons"] = _Icons;

            TempData["Menus"] = SelectListItems;

            return PartialView(new I.Menu());
        }

        [HttpPost]
        [Route("MenuUpdate/{MenuId}")]
        public PartialViewResult MenuUpdate(int MenuId)
        {
            var _UpdateMenu = IhaleServiceClient.GetMenu(MenuId);

            SelectListItems.Clear();
            _Icons.Clear();

            var _menus = IhaleServiceClient.GetMenus().Select(x => new { x.Id, x.Name }).ToList();

            foreach (var item in _menus)
            {
                if (_UpdateMenu.MenuId == item.Id)
                {
                    SelectListItems.Add(new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = item.Name,
                        Selected = true
                    });
                }

                else
                {
                    SelectListItems.Add(new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = item.Name
                    });

                }
            }

            var Icons = IhaleServiceClient.GetIcons().Select(x => new { x.Id, x.Name }).ToList();

            foreach (var item in Icons)
            {
                if (item.Id == _UpdateMenu.IconId)
                {
                    _Icons.Add(new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = item.Name,
                        Selected = true
                    });
                }
                else
                {
                    _Icons.Add(new SelectListItem
                    {
                        Value = item.Id.ToString(),
                        Text = item.Name
                    });
                }
            }


            TempData["Icons"] = _Icons;

            TempData["Menus"] = SelectListItems;

            return PartialView(_UpdateMenu);
        }


        [HttpPost]
        public JsonResult MenuAddOperation(I.Menu menu)
        {
            jsonResultModel.Title = "Ekleme İşlemi";
            jsonResultModel.Modal = "MenuAddModal";

            if (ModelState.IsValid)
            {
                IhaleServiceClient.AddMenu(menu);

                jsonResultModel.Icon = "success";
                jsonResultModel.Description = "Menü Başarıyla Eklendi";

            }
            else
            {
                jsonResultModel.Icon = "error";
                jsonResultModel.Description = "Lütfen eksiksiz doldurun";
            }
            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult MenuUpdateOperation(I.Menu menu)
        {
            jsonResultModel.Title = "Güncelleme İşlemi";
            jsonResultModel.Modal = "MenuUpdateModal";

            if (ModelState.IsValid)
            {
                IhaleServiceClient.UpdateMenu(menu);

                jsonResultModel.Icon = "success";
                jsonResultModel.Description = "Menü Başarıyla Güncellendi";

            }
            else
            {
                jsonResultModel.Icon = "error";
                jsonResultModel.Description = "Lütfen eksiksiz doldurun";
            }
            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
    }
}