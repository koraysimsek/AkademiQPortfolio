using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public TestimonialController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _portfolyodbContext.Testimonials.Add(testimonial);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = _portfolyodbContext.Testimonials.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _portfolyodbContext.Testimonials.Update(testimonial);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = _portfolyodbContext.Testimonials.Find(id);

            _portfolyodbContext.Testimonials.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
