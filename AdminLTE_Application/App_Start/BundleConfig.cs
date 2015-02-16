using System.Web;
using System.Web.Optimization;

namespace AdminLTE_Application
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                    "~/Scripts/jquery-ui.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/raphael").Include(
                    "~/Scripts/raphael-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-slider").Include(
                    "~/Scripts/plugins/bootstrap-slider/bootstrap-slider.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-wysihtml5").Include(
                    "~/Scripts/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/colorpicker").Include(
                    "~/Scripts/plugins/colorpicker/bootstrap-colorpicker.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                    "~/Scripts/plugins/datatables/jquery.dataTables.js",
                    "~/Scripts/plugins/datatables/dataTables.bootstrap.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include(
                    "~/Scripts/plugins/datepicker/bootstrap-datepicker.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/daterangepicker").Include(
                    "~/Scripts/plugins/daterangepicker/daterangepicker.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/flot").Include(
                    "~/Scripts/plugins/flot/jquery.flot.min.js",
                    "~/Scripts/plugins/flot/jquery.flot.resize.min.js",
                    "~/Scripts/plugins/flot/jquery.flot.pie.min.js",
                    "~/Scripts/plugins/flot/jquery.flot.categories.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/iCheck").Include(
                    "~/Scripts/plugins/iCheck/icheck.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/input-mask").Include(
                    "~/Scripts/plugins/input-mask/jquery.inputmask.js",
                    "~/Scripts/plugins/input-mask/jquery.inputmask.date.extensions.js",
                    "~/Scripts/plugins/input-mask/jquery.inputmask.extensions.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/ionslider").Include(
                    "~/Scripts/plugins/ionslider/ion.rangeSlider.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryKnob").Include(
                    "~/Scripts/plugins/jqueryKnob/jquery.knob.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jvectormap").Include(
                    "~/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                    "~/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/misc").Include(
                    "~/Scripts/plugins/misc/html5shiv.js",
                    "~/Scripts/plugins/misc/jquery.ba-resize.min.js",
                    "~/Scripts/plugins/misc/jquery.placeholder.js",
                    "~/Scripts/plugins/misc/modernizr.min.js",
                    "~/Scripts/plugins/misc/respond.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                    "~/Scripts/plugins/morris/morris.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/slimScroll").Include(
                    "~/Scripts/plugins/slimScroll/jquery.slimscroll.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/sparkline").Include(
                    "~/Scripts/plugins/sparkline/jquery.sparkline.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/timepicker").Include(
                    "~/Scripts/plugins/timepicker/bootstrap-timepicker.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/AdminLTE").Include(
                    "~/Scripts/AdminLTE/app.js",
                    "~/Scripts/AdminLTE/demo.js"));

            bundles.Add(new ScriptBundle("~/bundles/AdminLTE_Dashboard").Include(
               "~/Scripts/AdminLTE/dashboard.js"));

            bundles.Add(new ScriptBundle("~/bundles/Calendar").Include(
               "~/Scripts/plugins/calendar/moment.min.js",
               "~/Scripts/plugins/calendar/fullcalendar.min.js"));


            bundles.Add(new StyleBundle("~/Content/css/AdminLTE").Include(
                      "~/Content/css/AdminLTE.css"));    

            bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include(
                      "~/Content/css/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/bootstrap-slider").Include(
                    "~/Content/css/bootstrap-slider/slider.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/bootstrap-wysihtml5").Include(
                      "~/Content/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/colorpicker").Include(
                   "~/Content/css/colorpicker/bootstrap-colorpicker.min.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/datatables").Include(
                      "~/Content/css/datatables/dataTables.bootstrap.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/datepicker").Include(
                   "~/Content/css/datepicker/datepicker3.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/daterangepicker").Include(
                      "~/Content/css/daterangepicker/daterangepicker-bs3.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/iCheck").Include(
                   "~/Content/css/iCheck/all.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/ionslider").Include(
                   "~/Content/css/ionslider/ion.rangeSlider.css",
                   "~/Content/css/ionslider/ion.rangeSlider.skinNice.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/jvectormap").Include(
                      "~/Content/css/jvectormap/jquery-jvectormap-1.2.2.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/morris").Include(
                   "~/Content/css/morris/morris.css"));
            
            bundles.Add(new StyleBundle("~/Content/css/timepicker").Include(
                      "~/Content/css/timepicker/bootstrap-timepicker.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/calendar").Include(
                     "~/Content/css/plugins/calendar/fullCalendar.css",
                     "~/Content/css/plugins/calendar/fullCalendarPrint.css"));
             
        }
    }
}
