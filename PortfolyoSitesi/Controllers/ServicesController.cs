using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class ServicesController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ServicesController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _portfolyodbContext.Services.Add(service);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = _portfolyodbContext.Services.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _portfolyodbContext.Services.Update(service);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var values = _portfolyodbContext.Services.Find(id);

            _portfolyodbContext.Services.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
