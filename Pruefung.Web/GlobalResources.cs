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
            Angular = "~/Scripts/angular.js";
#else
            JQuery = "~/Scripts/jquery-3.1.1.min.js";
            Bootstrap = "~/Scripts/bootstrap.min.js";
            Angular = "~/Scripts/angular.min.js";
#endif
        }

        public static string JQuery { get; private set; }
        public static string Bootstrap { get; private set; }
        public static string Modernizr { get; private set; }
        public static string Angular { get; private set; }
    }

    public static class Styles
    {
        static Styles()
        {
            Site = "~/Content/Site.css";
#if DEBUG
            Bootstrap = "~/Content/bootstrap.css";
#else
            Bootstrap = "~/Content/bootstrap.min.css";
#endif
        }

        public static string Site { get; private set; }
        public static string Bootstrap { get; private set; }
    }
}