using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConventinalRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Students",
               url: "Stud",
               defaults: new { controller = "Demo", action = "GetData"}
           );

            routes.MapRoute(
                name:"Stud",
                url:"Stud/{id}",
                defaults: new {Controller="Demo",Action= "GetDataStud",id=UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Studs",
                url: "Studs/{id}",
                defaults: new { Controller = "Demo", Action = "GetDataAdress", id = UrlParameter.Optional }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
