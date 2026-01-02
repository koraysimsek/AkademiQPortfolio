using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public CategoryViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Categories.ToList();
            return View(values);
        }
    }
}
