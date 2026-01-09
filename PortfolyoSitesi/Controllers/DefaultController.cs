using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class DefaultController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public DefaultController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(string NameSurname, string Email, string Subject, string MessageContent)
        {
            PortfolyoSitesi.Data.Message cleanMessage = new PortfolyoSitesi.Data.Message();
            cleanMessage.NameSurname = NameSurname;
            cleanMessage.Email = Email;
            cleanMessage.Subject = Subject;
            cleanMessage.MessageContent = MessageContent;

            _portfolyodbContext.Messages.Add(cleanMessage);
            _portfolyodbContext.SaveChanges();

            TempData["MessageSent"] = "Message has been sent successfully!";

            return RedirectToAction("Index");
        }
    }
}
