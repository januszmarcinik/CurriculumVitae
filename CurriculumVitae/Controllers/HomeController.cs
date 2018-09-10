using System.Web.Mvc;

namespace CurriculumVitae.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexEN()
        {
            return View();
        }
    }
}