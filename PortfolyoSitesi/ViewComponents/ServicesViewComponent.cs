using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class ServicesViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ServicesViewComponent(portfolyodbContext portfolyodbContext)
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
