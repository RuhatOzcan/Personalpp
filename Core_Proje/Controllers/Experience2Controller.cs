using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PersonalWebsite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetById(int ExperienceId)
        {
            var v=experienceManager.TGetById(ExperienceId);
            var values= JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetById(id);
            experienceManager.TDelete(v);
            return NoContent();

        }

        [HttpPost]
        public IActionResult UpdateExperience(int ExperienceId, string Name, string Date)
        {
            var data = experienceManager.TGetById(ExperienceId);
            if (data != null)
            {
                data.Name = Name;
                data.Date = Date;
                experienceManager.TUpdate(data);
                var datas = JsonConvert.SerializeObject(data);

                return Json(datas);
            }
            else
            {
                return Json(new object());
            }
        }

    }
}
