using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
