using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public AboutViewComponent(PortfolyoDbContext portfolyodbContext)
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
