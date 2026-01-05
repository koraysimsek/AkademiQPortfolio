using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class SliderController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public SliderController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Sliders.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(Slider slider)
        {
            _portfolyodbContext.Sliders.Add(slider);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var values = _portfolyodbContext.Sliders.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            _portfolyodbContext.Sliders.Update(slider);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSlider(int id)
        {
            var values = _portfolyodbContext.Sliders.Find(id);

            _portfolyodbContext.Sliders.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
