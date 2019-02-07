using System;
using System.Web.Optimization;

namespace WebAppHomework.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jqeury-ui-{version}.js",
                    "~/Scripts.unbotrusive.ajax.js",
                    "~/Scripts/bootstrap.min.js"
                    ));

            bundles.Add(new StyleBundle("~/bundles/styles")
                .Include(
                    "~/Content/bootstrap.min.css"
                    ));

            bundles.Add(new StyleBundle("~/bundles/mainstyles")
                .Include(
                    "~/public/css/main.css"
                    ));
        }
    }
}