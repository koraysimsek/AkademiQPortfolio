using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class ServicesViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public ServicesViewComponent(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Services.ToList();
            return View(values);
        }
    }
}
