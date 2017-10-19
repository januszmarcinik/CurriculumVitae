using CurriculumVitae.Models;
using System.Web.Mvc;

namespace CurriculumVitae.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CurriculumVitaeViewModel(LangVersion.PL);
            return View(model);
        }

        public ActionResult IndexEN()
        {
            var model = new CurriculumVitaeViewModel(LangVersion.EN);
            return View(model);
        }
    }
}