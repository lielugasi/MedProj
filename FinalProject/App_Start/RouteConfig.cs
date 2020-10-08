using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FinalProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "admind",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Admin", action = "Admin", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "doc",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Doctor", action = "Doctor", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "client",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Client", action = "Client", id = UrlParameter.Optional }
          );
        }
    }
}
