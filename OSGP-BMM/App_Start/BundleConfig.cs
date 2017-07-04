using System.Web;
using System.Web.Optimization;

namespace OSGP_BMM
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/waves.js",
                      "~/Scripts/jquery.slimscroll.js",
                      "~/Scripts/sidebarmenu.js",
                      "~/Scripts/sidebarmenu.js",
                      "~/Scripts/custom.min.js",
                      "~/Scripts/jQuery.style.switcher.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/style.css",
                      "~/Content/spinners.css",
                      "~/Content/animate.css",
                      "~/Content/icons/themify-icons/themify-icons.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/colors/blue.css",
                      "~/Content/simple-line-icons/simple-line-icons.css",
                      "~/Content/site.css"));
        }
    }
}
