﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC
{
    static readonly MyCoolAreaClass s_MyCoolArea = new MyCoolAreaClass();
    public static MyCoolAreaClass MyCoolArea { get { return s_MyCoolArea; } }
    public static T4MVCSampleApp.Controllers.AccountController Account = new T4MVCSampleApp.Controllers.T4MVC_AccountController();
    public static T4MVCSampleApp.Controllers.HomeController Home = new T4MVCSampleApp.Controllers.T4MVC_HomeController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class MyCoolAreaClass
    {
        public readonly string Name = "MyCoolArea";
        public T4MVCSampleApp.Areas.MyCoolArea.Controllers.BlahController Blah = new T4MVCSampleApp.Areas.MyCoolArea.Controllers.T4MVC_BlahController();
        public T4MVC.MyCoolArea.SharedController Shared = new T4MVC.MyCoolArea.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_1_5_1_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.5.1-vsdoc.min.js") ? Url("jquery-1.5.1-vsdoc.min.js") : Url("jquery-1.5.1-vsdoc.js");
                      
        public static readonly string jquery_1_5_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.5.1.min.js") ? Url("jquery-1.5.1.min.js") : Url("jquery-1.5.1.js");
                      
        public static readonly string jquery_1_5_1_min_js = Url("jquery-1.5.1.min.js");
        public static readonly string jquery_ui_1_8_11_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.8.11.min.js") ? Url("jquery-ui-1.8.11.min.js") : Url("jquery-ui-1.8.11.js");
                      
        public static readonly string jquery_ui_1_8_11_min_js = Url("jquery-ui-1.8.11.min.js");
        public static readonly string jquery_unobtrusive_ajax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.unobtrusive-ajax.min.js") ? Url("jquery.unobtrusive-ajax.min.js") : Url("jquery.unobtrusive-ajax.js");
                      
        public static readonly string jquery_unobtrusive_ajax_min_js = Url("jquery.unobtrusive-ajax.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
                      
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
                      
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
                      
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string MicrosoftAjax_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftAjax.debug.min.js") ? Url("MicrosoftAjax.debug.min.js") : Url("MicrosoftAjax.debug.js");
                      
        public static readonly string MicrosoftAjax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftAjax.min.js") ? Url("MicrosoftAjax.min.js") : Url("MicrosoftAjax.js");
                      
        public static readonly string MicrosoftMvcAjax_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcAjax.debug.min.js") ? Url("MicrosoftMvcAjax.debug.min.js") : Url("MicrosoftMvcAjax.debug.js");
                      
        public static readonly string MicrosoftMvcAjax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcAjax.min.js") ? Url("MicrosoftMvcAjax.min.js") : Url("MicrosoftMvcAjax.js");
                      
        public static readonly string MicrosoftMvcValidation_debug_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcValidation.debug.min.js") ? Url("MicrosoftMvcValidation.debug.min.js") : Url("MicrosoftMvcValidation.debug.js");
                      
        public static readonly string MicrosoftMvcValidation_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/MicrosoftMvcValidation.min.js") ? Url("MicrosoftMvcValidation.min.js") : Url("MicrosoftMvcValidation.js");
                      
        public static readonly string modernizr_1_7_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-1.7.min.js") ? Url("modernizr-1.7.min.js") : Url("modernizr-1.7.js");
                      
        public static readonly string modernizr_1_7_min_js = Url("modernizr-1.7.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
             
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class @base {
                private const string URLPATH = "~/Content/themes/base";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/base/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string ui_bg_flat_0_aaaaaa_40x100_png = Url("ui-bg_flat_0_aaaaaa_40x100.png");
                    public static readonly string ui_bg_flat_75_ffffff_40x100_png = Url("ui-bg_flat_75_ffffff_40x100.png");
                    public static readonly string ui_bg_glass_55_fbf9ee_1x400_png = Url("ui-bg_glass_55_fbf9ee_1x400.png");
                    public static readonly string ui_bg_glass_65_ffffff_1x400_png = Url("ui-bg_glass_65_ffffff_1x400.png");
                    public static readonly string ui_bg_glass_75_dadada_1x400_png = Url("ui-bg_glass_75_dadada_1x400.png");
                    public static readonly string ui_bg_glass_75_e6e6e6_1x400_png = Url("ui-bg_glass_75_e6e6e6_1x400.png");
                    public static readonly string ui_bg_glass_95_fef1ec_1x400_png = Url("ui-bg_glass_95_fef1ec_1x400.png");
                    public static readonly string ui_bg_highlight_soft_75_cccccc_1x100_png = Url("ui-bg_highlight-soft_75_cccccc_1x100.png");
                    public static readonly string ui_icons_222222_256x240_png = Url("ui-icons_222222_256x240.png");
                    public static readonly string ui_icons_2e83ff_256x240_png = Url("ui-icons_2e83ff_256x240.png");
                    public static readonly string ui_icons_454545_256x240_png = Url("ui-icons_454545_256x240.png");
                    public static readonly string ui_icons_888888_256x240_png = Url("ui-icons_888888_256x240.png");
                    public static readonly string ui_icons_cd0a0a_256x240_png = Url("ui-icons_cd0a0a_256x240.png");
                }
            
                public static readonly string jquery_ui_accordion_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.accordion.min.css") ? Url("jquery.ui.accordion.min.css") : Url("jquery.ui.accordion.css");
                     
                public static readonly string jquery_ui_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.all.min.css") ? Url("jquery.ui.all.min.css") : Url("jquery.ui.all.css");
                     
                public static readonly string jquery_ui_autocomplete_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.autocomplete.min.css") ? Url("jquery.ui.autocomplete.min.css") : Url("jquery.ui.autocomplete.css");
                     
                public static readonly string jquery_ui_base_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.base.min.css") ? Url("jquery.ui.base.min.css") : Url("jquery.ui.base.css");
                     
                public static readonly string jquery_ui_button_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.button.min.css") ? Url("jquery.ui.button.min.css") : Url("jquery.ui.button.css");
                     
                public static readonly string jquery_ui_core_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.core.min.css") ? Url("jquery.ui.core.min.css") : Url("jquery.ui.core.css");
                     
                public static readonly string jquery_ui_datepicker_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.datepicker.min.css") ? Url("jquery.ui.datepicker.min.css") : Url("jquery.ui.datepicker.css");
                     
                public static readonly string jquery_ui_dialog_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.dialog.min.css") ? Url("jquery.ui.dialog.min.css") : Url("jquery.ui.dialog.css");
                     
                public static readonly string jquery_ui_progressbar_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.progressbar.min.css") ? Url("jquery.ui.progressbar.min.css") : Url("jquery.ui.progressbar.css");
                     
                public static readonly string jquery_ui_resizable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.resizable.min.css") ? Url("jquery.ui.resizable.min.css") : Url("jquery.ui.resizable.css");
                     
                public static readonly string jquery_ui_selectable_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.selectable.min.css") ? Url("jquery.ui.selectable.min.css") : Url("jquery.ui.selectable.css");
                     
                public static readonly string jquery_ui_slider_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.slider.min.css") ? Url("jquery.ui.slider.min.css") : Url("jquery.ui.slider.css");
                     
                public static readonly string jquery_ui_tabs_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.tabs.min.css") ? Url("jquery.ui.tabs.min.css") : Url("jquery.ui.tabs.css");
                     
                public static readonly string jquery_ui_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.ui.theme.min.css") ? Url("jquery.ui.theme.min.css") : Url("jquery.ui.theme.css");
                     
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


