using System.Web;
using System.Web.Optimization;

namespace AmigoDono.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.js",
                        "~/Scripts/jquery-ui-1.12.1.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/umd/popper.js",
                        "~/Scripts/umd/popper.utils.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/addjs").Include(
                        "~/Scripts/bootbox.js"));

           bundles.Add(new ScriptBundle("~/bundles/addcss").Include(
                        "~/Content/fonteawesome.css",
                        "~/Content/form-validation"));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
                    "~/Scripts/jquery.inputmask/inputmask.js",
                    "~/Scripts/jquery.inputmask/jquery.inputmask.js",
                                "~/Scripts/jquery.inputmask/inputmask.extensions.js",
                                "~/Scripts/jquery.inputmask/inputmask.date.extensions.js",
                                "~/Scripts/jquery.inputmask/inputmask.numeric.extensions.js"));
        }
    }
}
