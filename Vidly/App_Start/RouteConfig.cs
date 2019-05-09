using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*
            routes.MapRoute(
                "Customers",
                "Customers/{ViewCustomers}/",
                new { controller = "Customers", action = "ViewCustomers" }
            );
           
            routes.MapRoute(
                "ViewCustomer",
                "Customers/{ViewIndividualCustomer}/{id}",
                new { controller = "Customers", action = "ViewIndividualCustomer", id = UrlParameter.Optional }
            );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            /*
            routes.MapRoute(
                name: "DefaultView",
                url: "{controller}/{action}/",
                defaults: new { controller = "Home", action = "Index" }
                );*/
        }
    }
}
