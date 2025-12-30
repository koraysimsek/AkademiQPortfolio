using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ContactViewComponent(portfolyodbContext portfolyodbContext)
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
