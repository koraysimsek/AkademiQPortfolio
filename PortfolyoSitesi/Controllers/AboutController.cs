using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class AboutController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public AboutController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _portfolyodbContext.Abouts.Add(about);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _portfolyodbContext.Abouts.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _portfolyodbContext.Abouts.Update(about);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var values = _portfolyodbContext.Abouts.Find(id);

            _portfolyodbContext.Abouts.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
