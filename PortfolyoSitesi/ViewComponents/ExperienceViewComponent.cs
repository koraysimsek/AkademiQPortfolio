using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public ExperienceViewComponent(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Experiences.ToList();
            return View(values);
        }
    }
}
