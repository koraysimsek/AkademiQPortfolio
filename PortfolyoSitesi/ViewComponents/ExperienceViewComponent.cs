using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
