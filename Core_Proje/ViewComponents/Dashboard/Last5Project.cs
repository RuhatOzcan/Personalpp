﻿using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.Dashboard
{
    public class Last5Project : ViewComponent
    {
        public IViewComponentResult Invoke()
        {     
            return View();
        }

    }
}
