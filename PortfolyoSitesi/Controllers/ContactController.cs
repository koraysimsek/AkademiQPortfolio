using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class ContactController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public ContactController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IActionResult Index()
        {
            var values = _portfolyodbContext.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _portfolyodbContext.Contacts.Add(contact);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = _portfolyodbContext.Contacts.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _portfolyodbContext.Contacts.Update(contact);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact(int id)
        {
            var values = _portfolyodbContext.Contacts.Find(id);

            _portfolyodbContext.Contacts.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
