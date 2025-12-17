using Microsoft.AspNetCore.Mvc;

namespace PortfolyoSitesi.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
