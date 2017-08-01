using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UEditor.Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add(new UEditor.UEditorRoute("/ueditors/Demo1/api", UEditorConfigure.Demo1));

            routes.Add(new UEditor.UEditorRoute("/ueditors/Demo2/api", UEditorConfigure.Demo2));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UEditor", action = "Demo1", id = UrlParameter.Optional }
            );
        }
    }
}
