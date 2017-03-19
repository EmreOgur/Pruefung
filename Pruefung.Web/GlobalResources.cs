using System.Collections.Generic;

namespace Pruefung.Web
{
    public static class Scripts
    {
        static Scripts()
        {
            Modernizr = "~/Scripts/modernizr-2.8.3.js";
#if DEBUG
            JQuery = "~/Scripts/jquery-3.1.1.js";
            Bootstrap = "~/Scripts/bootstrap.js";
            Angular = new[] { "~/Scripts/angular.js", "~/Scripts/angular-animate.js", "~/Scripts/angular-sanitize.js" };
            AngularUI = "~/Scripts/angular-ui/ui-bootstrap.js";
#else
            JQuery = "~/Scripts/jquery-3.1.1.min.js";
            Bootstrap = "~/Scripts/bootstrap.min.js";
            Angular = new[] { "~/Scripts/angular.min.js", "~/Scripts/angular-animate.min.js","~/Scripts/angular-sanitize.min.js" };
            AngularUI = "~/Scripts/angular-ui/ui-bootstrap.js";
#endif
        }

        public static string JQuery { get; private set; }
        public static string Bootstrap { get; private set; }
        public static string Modernizr { get; private set; }
        public static IReadOnlyCollection<string> Angular { get; private set; }
        public static string AngularUI { get; private set; }
    }

    public static class Styles
    {
        static Styles()
        {
            Site = "~/Content/Site.css";
#if DEBUG
            Bootstrap = "~/Content/bootstrap.css";
            BootstrapUI="~/Content/ui-bootstrap-csp.css";
#else
            Bootstrap = "~/Content/bootstrap.min.css";
            BootstrapUI="~/Content/ui-bootstrap-csp.css";
#endif
        }

        public static string Site { get; private set; }
        public static string Bootstrap { get; private set; }
        public static string BootstrapUI { get; private set; }
    }
}