using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.Dashboard
{
    public class VisitorMap:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
