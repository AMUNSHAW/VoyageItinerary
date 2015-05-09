using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VoyageItinerary
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CreateItinerary", action = "HomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CreateItinerary",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CreateItinerary", action = "CreateItinerary", id = UrlParameter.Optional }
            );
        }
    }
}
