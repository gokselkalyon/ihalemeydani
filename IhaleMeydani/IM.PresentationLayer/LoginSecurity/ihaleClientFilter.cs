
using IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace IM.PresentationLayer.LoginSecurity
{
    public class ihaleClientFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        private readonly string _claimText;
        public ihaleClientFilter(string claimText)
        {
            this._claimText = claimText;

        }
        public void OnAuthentication(AuthenticationContext filterContext)
        { 
            var Id = SessionManager.CurrentUser.Id;
            var claim = SessionManager.CurrentUser.claimText;
            if (Id != 0)
            {
                var user = claim.Contains(_claimText);

                if (!user)
                    filterContext.Result = new RedirectResult("/Login");
            }
            else
            {
                    filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {

                var user = filterContext.HttpContext.User;
                if (user == null || !user.Identity.IsAuthenticated)
                {
                    filterContext.Result = new RedirectResult("/Login");
                }

            }


            //var color = ((MyCustomPrincipal)filterContext.HttpContext.User).HairColor;
            //var user = filterContext.HttpContext.User;

            //if (!user.Identity.IsAuthenticated)
            //{
            //    filterContext.Result = new HttpUnauthorizedResult();
            //}
        }
    }
}
