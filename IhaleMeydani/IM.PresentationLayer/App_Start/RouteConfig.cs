using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IM.PresentationLayer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Error",
                url: "{controller}/{action}/{error}",
                defaults: new { controller = "Errors", action = "Error404", error = UrlParameter.Optional }
            );
        }
    }
}
