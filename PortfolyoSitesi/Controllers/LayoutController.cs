using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
