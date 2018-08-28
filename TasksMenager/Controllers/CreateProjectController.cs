using System.Web.Mvc;
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

            return RedirectToAction("Index");
        }
    }
}