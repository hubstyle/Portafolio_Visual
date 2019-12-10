using System.Web.Optimization;

namespace Cliente.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
               bundles.Add(new StyleBundle("~/bundle/css")
                .Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/vendor/fontawesome-free/css/all.min.css",
                /*"https://fonts.googleapis.com/css?family=Montserrat:400,700",
                "https://fonts.googleapis.com/css?family=Kaushan+Script",
                "https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic",
                "https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700",*/
                "~/Content/css/agency.min.css"
                ));

                 bundles.Add(new ScriptBundle("~/bundle/js")
                .Include(
                "~/Content/vendor/jquery/jquery.min.js",
                "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                "~/Content/js/jqBootstrapValidation.js",
                "~/Content/js/contact_me.js",
                "~/Content/js/agency.min.js"
                ));
        }

    }
}