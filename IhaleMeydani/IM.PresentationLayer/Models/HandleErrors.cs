using IM.DataLayer;
using I = IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using IM.DataAccessLayer.Concrete.EFConcrete;
using System.Web.Routing;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Helper;

namespace IM.PresentationLayer.Models
{
    [AllowAnonymous]
    public class HandleErrors : ActionFilterAttribute
    {
        private IhaleServiceClient IhaleServiceClient = Singleton.GetIhaleinstance();

        private Stopwatch _stopwatch;
        int UserId;
        private UserConcrete userConcrete = new UserConcrete();
        //private LogInfoesConcrete logInfoes = new LogInfoesConcrete();
        //private LogConcrete logConcrete = new LogConcrete();

        public HandleErrors()
        {
            _stopwatch = new Stopwatch();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _stopwatch.Reset();
            _stopwatch.Start();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _stopwatch.Stop();  //kronometreyi durdur

            filterContext.ExceptionHandled = true;

            var request = filterContext.HttpContext.Request;

            var exceptions = filterContext.Exception;

            if (exceptions != null)
            {

                if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    UserId = userConcrete.GetFilter(x => x.UserName == filterContext.HttpContext.User.Identity.Name).Single().Id;
                }

                IhaleServiceClient.AddLog(new I.Log
                {
                    UserId = UserId,
                    AddedDate = DateTime.Now,
                    Data = SerializeRequest(request),
                    ExecutionMs = _stopwatch.ElapsedMilliseconds,
                    IPAddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? request.UserHostAddress,
                    UrlAccessed = request.RawUrl, //erişilen sayfanın ham url'i
                    LogStatusId = 2
                });

                IhaleServiceClient.AddLogInfo(new I.LogInfo
                {
                    UserId = UserId,
                    Controller = filterContext.RouteData.Values["controller"].ToString(),
                    Action = filterContext.RouteData.Values["action"].ToString(),
                    Date = DateTime.Now,
                    Type = filterContext.Exception.GetType().ToString(),
                    ExceptionMessage = GetInnerexception(filterContext.Exception).Message,
                    LogStatusId = 2
                });


                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    var viewResult = new JsonResult();

                    viewResult.Data = new JsonResultModel
                    {
                        Title = "Hata",
                        Description = "Hata Meydana Geldi",
                        Icon = "error",
                        Url = ""
                    };
                    filterContext.Result = viewResult;
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Errors", action = "PageError", exception = exceptions }));
                }
            }
            else
            {
                if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                {

                    UserId = userConcrete.GetFilter(x => x.UserName == filterContext.HttpContext.User.Identity.Name).Single().Id;
                }

                IhaleServiceClient.AddLog(new I.Log
                {
                    UserId = UserId,
                    AddedDate = DateTime.Now,
                    Data = SerializeRequest(request),
                    ExecutionMs = _stopwatch.ElapsedMilliseconds,
                    IPAddress = request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? request.UserHostAddress,
                    UrlAccessed = request.RawUrl, //erişilen sayfanın ham url'i
                    LogStatusId = 1
                });

                IhaleServiceClient.AddLogInfo(new I.LogInfo
                {
                    UserId = UserId,
                    Controller = filterContext.RouteData.Values["controller"].ToString(),
                    Action = filterContext.RouteData.Values["action"].ToString(),
                    Date = DateTime.Now,
                    Type = string.Empty,
                    ExceptionMessage = "İşlem Başarıyla Gerçekleşti",
                    LogStatusId = 1
                });
            }

            base.OnActionExecuted(filterContext);
        }
        private Exception GetInnerexception(Exception exception)
        {
            if (exception.InnerException != null)
                return GetInnerexception(exception.InnerException);
            else
                return exception;
        }
        private string SerializeRequest(HttpRequestBase request)
        {
            string result = string.Empty;
            #region Form
            List<string> formVals = new List<string>(); //eğer sayfada bir form varsa, formda gönderilen tüm inputları alıp bir listeye atıyorum.
            if (request.Form.AllKeys != null && request.Form.AllKeys.ToList().Count > 0)
            {
                foreach (string s in request.Form.AllKeys.ToList())
                {
                    formVals.Add(request.Form[s]);
                }
            }
            #endregion

            result = Json.Encode(new
            {
                request.Form,    //gönderilen formun tamamı
                formVals,   //formdaki inputlara girilen veriler
                request.Browser.Browser,    //kullanıcının tarayıcısı
                request.Browser.IsMobileDevice,     //istek bir mobil cihazdan mı geldi
                request.Browser.Version,    //kullanıcının tarayıcı versiyonu
                request.UserAgent,      //yönlendiren kuruluşu bulmamızı sağlayan useragent bilgisi
                request.UserLanguages,  //tarayıcı dili
                request.UrlReferrer     //yönlendiren sayfayı bulmamızı sağlayan urlreferrer bilgisi
            });     //tüm bu bilgileri serialize edip stringe çeviriyorum

            return result;
        }
    }
}