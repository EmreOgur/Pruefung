using System.Web.Mvc;

namespace Pruefung.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return RedirectToAction("Index","Admin");
        }
    }
}