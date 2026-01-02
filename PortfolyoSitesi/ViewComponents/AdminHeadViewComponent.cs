using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitesi.ViewComponents
{
    public class AdminHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
