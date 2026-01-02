using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitesi.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
