using System.Web.Mvc;

namespace TasksMenager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact Page.";

            return View();
        }
    }
}