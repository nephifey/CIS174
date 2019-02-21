using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "AboutPage",
                "about",
                new { controller = "Home", action = "About", });

            routes.MapRoute(
                "GamePage",
                "games",
                new { controller = "Home", action = "Game", });

            routes.MapRoute(
                "Register",
                "register",
                new { controller = "Account", action = "Register", });

            routes.MapRoute(
                "Login",
                "login",
                new { controller = "Account", action = "Login", });

            routes.MapRoute(
                "Update",
                "profile",
                new { controller = "Manage", action = "Update", });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
