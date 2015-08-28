﻿using System.Web;
using System.Web.Optimization;

namespace ShoppingCartMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/shoppingCart").Include(
 "~/Scripts/jquery-{version}.js", "~/Scripts/jquery.validate*",
 "~/Scripts/jquery-ui.js", "~/Scripts/bootstrap.js",
 "~/Scripts/respond.js", "~/Scripts/knockout-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
            "~/Content/bootstrap.css",
            "~/Content/site.css"));
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
