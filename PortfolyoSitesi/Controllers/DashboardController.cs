using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class DashboardController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public DashboardController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            ViewBag.ProjectsCount = _portfolyodbContext.Projects.Count();
            ViewBag.LastProject = _portfolyodbContext.Projects.OrderByDescending(x => x.ProjectId).FirstOrDefault().ProjectName;

            return View();
        }
    }
}
