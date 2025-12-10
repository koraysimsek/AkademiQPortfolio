using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
