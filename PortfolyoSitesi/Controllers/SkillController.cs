using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.Controllers
{
    public class SkillController : Controller
    {

        private readonly portfolyodbContext _portfolyodbContext;

        public SkillController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Skills.ToList();
            return View(values);
        }

        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = _portfolyodbContext.Skills.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _portfolyodbContext.Skills.Update(skill);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = _portfolyodbContext.Skills.Find(id);

            _portfolyodbContext.Skills.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
