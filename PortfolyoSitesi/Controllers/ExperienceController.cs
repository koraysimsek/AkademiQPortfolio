using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateExperience()
        {
            return View();
        }

        public IActionResult UpdateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteExperience()
        {
            return View();
        }
    }
}
