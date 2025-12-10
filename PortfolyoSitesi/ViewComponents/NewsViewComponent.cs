using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class NewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
