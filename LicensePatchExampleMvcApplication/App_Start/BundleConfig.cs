using System.Web;
using System.Web.Optimization;

namespace LicensePatchExampleMvcApplication
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/assets/css/bootstrap")
                .Include("~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/assets/js/bootstrap")
                .Include("~/Scripts/bootstrap/js/*transition.js")
                .Include("~/Scripts/bootstrap/js/*alert.js")
                //.Include("~/Scripts/bootstrap/js/*button.js")
                //.Include("~/Scripts/bootstrap/js/*carousel.js")
                .Include("~/Scripts/bootstrap/js/*collapse.js")
                .Include("~/Scripts/bootstrap/js/*dropdown.js")
                .Include("~/Scripts/bootstrap/js/*modal.js")
                //.Include("~/Scripts/bootstrap/js/*tooltip.js")
                //.Include("~/Scripts/bootstrap/js/*popover.js")
                //.Include("~/Scripts/bootstrap/js/*scrollspy.js")
                //.Include("~/Scripts/bootstrap/js/*tab.js")
                //.Include("~/Scripts/bootstrap/js/*affix.js")
            );

            bundles.Add(new ScriptBundle("~/assets/js/jQuery")
                .Include("~/Scripts/jquery-{version}.js"));
        }
    }
}