using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public ContactViewComponent(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.Contacts.ToList();
            return View(values);
        }
    }
}
