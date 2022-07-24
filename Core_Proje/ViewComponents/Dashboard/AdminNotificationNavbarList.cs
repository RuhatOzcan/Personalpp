using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.Dashboard
{
    public class AdminNotificationNavbarList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
