using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public TestimonialViewComponent(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Testimonials.ToList();
            return View(values);
        }
    }
}
