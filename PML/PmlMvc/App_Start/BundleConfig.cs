using System.Web;
using System.Web.Optimization;

namespace PmlMvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilizzare la versione di sviluppo di Modernizr per eseguire attività di sviluppo e formazione. Successivamente, quando si è
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/theme/material.js",
                      "~/Scripts/theme/chartist.js",
                      "~/Scripts/theme/arrive.js",
                      "~/Scripts/theme/perfect-scrollbar.jquery.js",
                      "~/Scripts/theme/bootstrap-notify.js",
                      "~/Scripts/theme/material-dashboard.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/material-dashboard.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
