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
            context.MapRouteArea(
                "MyCoolArea_default",
                "MyCoolArea/{controller}/{action}/{id}",
                MVC.MyCoolArea.Blah.Index().AddRouteValue("id", UrlParameter.Optional)
            );
        }
    }
}
