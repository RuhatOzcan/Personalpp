using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
            var values = portfolioManager.TGetList();
            return View(values);
        }


    }
}
