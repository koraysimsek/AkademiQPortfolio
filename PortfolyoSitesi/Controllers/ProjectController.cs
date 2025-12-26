using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolyoSitesi.Data;

namespace AkademiQPortfolyoSitesi.Controllers;
public class ProjectController : Controller
{
    private readonly portfolyodbContext _portfolyodbContext;

    public ProjectController(portfolyodbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }

    public IActionResult Index()
    {
        var values = _portfolyodbContext.Projects.Include(x => x.Category).ToList();
        return View(values);
    }

    // SelectListItem --> Dropdown listede gösterilecek her bir seçeneği temsil eden yapıdır

    [HttpGet]
    public IActionResult CreateProject()
    {
        ViewBag.Categories = _portfolyodbContext.Categories.Select(
            x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }
            );
        return View();
    }

    [HttpPost]
    public IActionResult CreateProject(Project project)
    {
        _portfolyodbContext.Projects.Add(project);
        _portfolyodbContext.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateProject(int id)
    {
        ViewBag.Categories = _portfolyodbContext.Categories.Select(
            x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }
            );

        var values = _portfolyodbContext.Projects.Find(id);

        return View(values);
    }

    [HttpPost]
    public IActionResult UpdateProject(Project project)
    {
        _portfolyodbContext.Projects.Update(project);
        _portfolyodbContext.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult DeleteProject(int id)
    {
        var values = _portfolyodbContext.Projects.Find(id);

        _portfolyodbContext.Projects.Remove(values);
        _portfolyodbContext.SaveChanges();

        return RedirectToAction("Index");
    }
}

