﻿using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using I = IM.PresentationLayer.IhaleWCFService;

namespace IM.PresentationLayer.Controllers
{
    public class IconsController : BaseController
    {
        [Route("Icons")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("IconList")]
        public PartialViewResult List()
        {
            return PartialView(IhaleServiceClient.GetIcons().ToList());
        }

        [HttpPost]
        [Route("UpdateIcon")]
        public PartialViewResult Update(int id)
        {
            var _icon = IhaleServiceClient.GetIcon(id);
            return PartialView(_icon);
        }

        public PartialViewResult Add()
        {
            return PartialView(new IconModelView());
        }
        [HttpPost]
        public JsonResult IconAddOperation(IconModelView icon)
        {
            if (ModelState.IsValid)
            {
                IhaleServiceClient.AddIcon(new I.Icon
                {
                    Name = icon.Name
                });

                jsonResultModel.Title = "Ekleme İşlemi";
                jsonResultModel.Icon = "success";
                jsonResultModel.Modal = "IconAddModal";
                jsonResultModel.Description = "İcon Başarıyla Eklendi";
            }
            else
            {
                jsonResultModel.Title = "Ekleme İşlemi";
                jsonResultModel.Icon = "warning";
                jsonResultModel.Modal = "IconAddModal";
                jsonResultModel.Description = "İcon Ekleme Başarısız";
            }


            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("RemoveIcon")]
        public JsonResult IconRemoveOperation(int id)
        {
            IhaleServiceClient.RemoveIcon(id);

            jsonResultModel.Title = "Silme İşlemi";
            jsonResultModel.Icon = "success";
            jsonResultModel.Description = "İcon Başarıyla Silindi";


            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult IconUpdateOperation(IconModelView icon)
        {
            if (ModelState.IsValid)
            {
                IhaleServiceClient.UpdateIcon(new I.Icon
                {
                    Id = icon.Id,
                    Name = icon.Name
                });

                jsonResultModel.Title = "Güncelleme İşlemi";
                jsonResultModel.Icon = "success";
                jsonResultModel.Modal = "IconUpdateModal";
                jsonResultModel.Description = "İcon Başarıyla Güncellendi";
            }
            else
            {
                jsonResultModel.Title = "Güncelleme İşlemi";
                jsonResultModel.Icon = "warning";
                jsonResultModel.Modal = "IconUpdateModal";
                jsonResultModel.Description = "İcon Güncelleme Başarısız";
            }


            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }

    }
}