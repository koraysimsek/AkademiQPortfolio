using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public ProjectViewComponent(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Projects.Include(x => x.Category).ToList();
            return View(values);
        }
    }
}
