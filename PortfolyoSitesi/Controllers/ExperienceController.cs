using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public ExperienceController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _portfolyodbContext.Experiences.Add(experience);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = _portfolyodbContext.Experiences.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _portfolyodbContext.Experiences.Update(experience);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = _portfolyodbContext.Experiences.Find(id);

            _portfolyodbContext.Experiences.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
