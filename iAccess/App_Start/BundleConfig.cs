using System.Web;
using System.Web.Optimization;

namespace iAccess
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/styles_bundle/").Include(
                "~/AdminLTE/bower_components/bootstrap/dist/css/bootstrap.min.css",
                "~/AdminLTE/bower_components/font-awesome/css/font-awesome.min.css",
                "~/AdminLTE/bower_components/Ionicons/css/ionicons.min.css",
                "~/AdminLTE/bower_components/select2/dist/css/select2.min.css",
                "~/AdminLTE/dist/css/AdminLTE.min.css",
                "~/AdminLTE/dist/css/skins/skin-purple.min.css",
                "~/Sitel/fonts/GoogleFontCSS.css",
                "~/Sitel//css/iAccessStyleSheet.css"
                ));

            bundles.Add(new ScriptBundle("~/scripts_bundle/").Include(
                "~/AdminLTE/bower_components/jquery/dist/jquery.js",
                "~/AdminLTE/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/AdminLTE/bower_components/select2/dist/js/select2.min.js",
                "~/AdminLTE/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/AdminLTE/bower_components/fastclick/lib/fastclick.js",
                "~/AdminLTE/dist/js/adminlte.min.js",                
                "~/Sitel/js/jquery.validate*"
                ));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/modernizr/").Include(
                        "~/Sitel/js/modernizr-*"));
        }
    }
}
