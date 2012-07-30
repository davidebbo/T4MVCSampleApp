using System.Web.Mvc;

namespace T4MVCSampleApp.Areas.MyCoolArea
{
    public class MyCoolAreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MyCoolArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MyCoolArea_default",
                "MyCoolArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
