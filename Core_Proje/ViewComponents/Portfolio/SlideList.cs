using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values = portfolioManager.TGetList();
            return View(values);
        }

    
    }
}
