using Microsoft.AspNetCore.Mvc;
using PortfolyoSitesi.Data;

namespace PortfolyoSitesi.Controllers
{
    public class CategoryController : Controller
    {
        private readonly PortfolyoDbContext _portfolyodbContext;

        public CategoryController(PortfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _portfolyodbContext.Categories.Add(category);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _portfolyodbContext.Categories.Find(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _portfolyodbContext.Categories.Update(category);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var values = _portfolyodbContext.Categories.Find(id);

            _portfolyodbContext.Categories.Remove(values);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
