using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class DashboardController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public DashboardController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            ViewBag.ProjectsCount = _portfolyodbContext.Projects.Count();
            ViewBag.LastProject = _portfolyodbContext.Projects.OrderByDescending(x => x.ProjectId).FirstOrDefault().ProjectName;

            ViewBag.ServicesCount = _portfolyodbContext.Services.Count();
            ViewBag.LastService = _portfolyodbContext.Services.OrderByDescending(x => x.ServiceId).FirstOrDefault().Title;

            ViewBag.TestimonialsCount = _portfolyodbContext.Testimonials.Count();
            ViewBag.LastTestimonial = _portfolyodbContext.Testimonials.OrderByDescending(x => x.TestimonialId).FirstOrDefault().TestimonialName;

            ViewBag.MessagesCount = _portfolyodbContext.Messages.Count();
            ViewBag.LastMessageSender = _portfolyodbContext.Messages.OrderByDescending(x => x.MessageId).FirstOrDefault().NameSurname;

            ViewBag.FirstExperienceTitle = _portfolyodbContext.Experiences.OrderBy(x => x.StartDate).Select(x => x.Title).FirstOrDefault();

            ViewBag.FirstProjectName = _portfolyodbContext.Projects.OrderBy(x => x.ProjectId).Select(x => x.ProjectName).FirstOrDefault();

            ViewBag.LastSkill = _portfolyodbContext.Skills.OrderByDescending(x => x.SkillId).FirstOrDefault().SkillName;

            var mostProjectCategory = _portfolyodbContext.Projects.GroupBy(p => p.Category.CategoryName).Select(g => new
        {
            CategoryName = g.Key,
            ProjectCount = g.Count()
        }).OrderByDescending(x => x.ProjectCount).FirstOrDefault();

            ViewBag.MostCategoryName = mostProjectCategory?.CategoryName;
            ViewBag.MostCategoryCount = mostProjectCategory?.ProjectCount;

            var topSkill = _portfolyodbContext.Skills.OrderByDescending(s => s.SkillPercentage).Select(s => new
        {
            s.SkillName,
            s.SkillPercentage
        }).FirstOrDefault();

            ViewBag.TopSkillName = topSkill?.SkillName;
            ViewBag.TopSkillLevel = topSkill?.SkillPercentage;

            //1 -) En çok projeye sahip kategori

            // 2-) Yenekler tablosunda en yüksek levelli yetenek

            // 3 Tanesini de siz belirleyin.
            return View();
        }
    }
}
