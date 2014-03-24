using System.Web;
using System.Web.Optimization;

namespace AngularBootstrap
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular/vendor").Include(
                "~/scripts/angular/vendor/angular.js",
                "~/scripts/angular/vendor/angular-bootstrap.js",
                "~/scripts/angular/vendor/angular-ui.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular/app").Include(
                    "~/scripts/angular/app.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/angular-ui.css",
                      "~/Content/site.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/jqueryui/css").Include(
                "~/content/themes/base/jquery-ui.css"
                ));

            //bundles.Add(new LessBundle("~/content/bootswatch").Include(
            //        "~/content/variables.less",
            //        "~/content/bootswatch.less"
            //    ));


        }
    }
}
