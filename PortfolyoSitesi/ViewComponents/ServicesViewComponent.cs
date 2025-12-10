using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class ServicesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
