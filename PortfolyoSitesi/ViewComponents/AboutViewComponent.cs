using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public AboutViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Abouts.ToList();
            return View(values);
        }
    }
}
