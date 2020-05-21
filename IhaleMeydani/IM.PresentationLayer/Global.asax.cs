using IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IM.PresentationLayer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError(); //Oluşan hatayı değişkene atadık.
                                                   //Eğer hata kaydı (log) tutulacak ise gerekli kodlar buraya.
            var httpException = exception as HttpException;
            Response.Clear();
            Server.ClearError(); //Sunucudaki hatayı temizledik.
            Response.TrySkipIisCustomErrors = true; //IIS'in tipik hata sayfalarını görmezden geldik.
            var routeData = new RouteData();
            routeData.Values["controller"] = "Errors"; //Hata mesajlarını yöneteceğimiz Controller ismi
            routeData.Values["action"] = "PageError"; //Controller içindeki default Action ismi
            routeData.Values["exception"] = exception;
            //Response.StatusCode = 500;

            if (httpException != null)
            {
                Response.StatusCode = httpException.GetHttpCode();

                switch (Response.StatusCode)
                {
                    case 403: //Eğer 403 hatası meydana gelmiş ise Http403 Action'ı devreye girecek.
                        routeData.Values["action"] = "Error403";
                        break;
                    case 404: //Eğer 404 hatası meydana gelmiş ise Http404 Action'ı devreye girecek.
                        routeData.Values["action"] = "Error404";
                        break;
                    case 401:
                        routeData.Values["Action"] = "Error401";
                        break;
                    case 500:
                        routeData.Values["Action"] = "Error500";
                        break;
                }
            }

            IController errorsController = new Controllers.ErrorsController();
            var rc = new RequestContext(new HttpContextWrapper(Context), routeData);
            errorsController.Execute(rc);
        }
    }
}
