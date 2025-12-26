using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ExperienceViewComponent(portfolyodbContext portfolyodbContext)
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
