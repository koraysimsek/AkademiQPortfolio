using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public SkillViewComponent(PortfolyoDbContext portfolyodbContext)
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
