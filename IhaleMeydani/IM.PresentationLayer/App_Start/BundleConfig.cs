using System.Web;
using System.Web.Optimization;

namespace IM.PresentationLayer
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/Template/js/jquery.js",
                      "~/Content/Template/js/boostrap.js",
                      "~/Content/Template/js/sweetalert2.js",
                      "~/Content/Template/autoshop/assets/js/plugins.js",
                      "~/Content/Template/autoshop/assets/js/functions.js"
                      ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/Template/autoshop/assets/css/external.css",
                      "~/Content/Template/autoshop/assets/css/bootstrap.min.css",
                      "~/Content/Template/autoshop/assets/css/style.css"
                      ));
        }
    }
}
