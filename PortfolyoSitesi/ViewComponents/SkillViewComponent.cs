using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public SkillViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Skills.ToList();
            return View(values);
        }
    }
}
