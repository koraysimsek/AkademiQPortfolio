using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public TestimonialViewComponent(portfolyodbContext portfolyodbContext)
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
