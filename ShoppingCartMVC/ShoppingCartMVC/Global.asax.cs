﻿using ShoppingCartMVC.DAL;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
=======
using System.Data.Entity;
>>>>>>> Dat
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ShoppingCartMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
<<<<<<< HEAD
            var dbContext = new ShoppingCartContext();
            Database.SetInitializer(new DataInitialization());
            dbContext.Database.Initialize(true);
=======

            var dbContext = new ShoppingCartContext();

            Database.SetInitializer(new DataInitialization());

            dbContext.Database.Initialize(true);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Add("__MyAppSession", string.Empty);
>>>>>>> Dat
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Add("__MyAppSession", string.Empty);
        }
    }
    }
}

