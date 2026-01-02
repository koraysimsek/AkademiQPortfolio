using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class ProjectViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ProjectViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Projects.ToList();
            return View(values);
        }
    }
}
