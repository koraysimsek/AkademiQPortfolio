using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
