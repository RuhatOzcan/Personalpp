using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccesLayer.EntityFramework;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactManager = new(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);

        }
    }
}
