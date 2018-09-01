using System.Web.Mvc;
using TasksMenager.Models.DatabaseModels;
using TasksMenager.Models.ViewModels;

namespace TasksMenager.Controllers
{
    public class CreateProjectController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            
            return View(new CreateProjectViewModel());
        }

        [HttpPost]
        public ActionResult CreateProject(CreateProjectViewModel createProjectViewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext db = new ApplicationDbContext();

                Project project = AutoMapper.Mapper.Map<CreateProjectViewModel, Project>(createProjectViewModel);

                db.Projects.Add(project);
                db.SaveChanges();
            }
            else return View("Index", createProjectViewModel);

            return RedirectToAction("Index");
        }
    }
}