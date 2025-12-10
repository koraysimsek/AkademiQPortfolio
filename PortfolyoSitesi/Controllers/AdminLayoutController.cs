using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
