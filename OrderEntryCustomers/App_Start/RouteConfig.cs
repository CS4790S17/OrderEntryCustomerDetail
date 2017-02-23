﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ViewModelTemplate
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "orderDetails",
                url: "customer/orderDetails/{custNo}",
                defaults: new { controller = "Customer", action = "orderDetails" }
            );

            routes.MapRoute(
                name: "customerList",
                url: "customer",
                defaults: new { controller = "Customer", action = "customer"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
