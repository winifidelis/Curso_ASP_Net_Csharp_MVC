﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"Todas as noticias",
                url:"noticias/",
                defaults: new { controller = "Home", action= "TodasAsNoticias" }
                );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}/",
                defaults: new { controller = "Home", action = "MostraCategoria" }
                );

            routes.MapRoute(
                name: "Mostrar Noticia",
                url: "noticias/{categoria}/{titulo} - {noticiaID}/",
                defaults: new { controller = "Home", action = "MostrarNoticia" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
