using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public SliderViewComponent(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Sliders.ToList();
            return View(values);
        }
    }
}
