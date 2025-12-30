using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class MessageController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public MessageController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IActionResult Index()
        {
            var values = _portfolyodbContext.Messages.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            _portfolyodbContext.Messages.Add(message);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var values = _portfolyodbContext.Messages.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateMessage(Message message)
        {
            _portfolyodbContext.Messages.Update(message);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _portfolyodbContext.Messages.Find(id);

            _portfolyodbContext.Messages.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
