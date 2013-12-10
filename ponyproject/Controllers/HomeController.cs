using System.Web.Mvc;
using ponyproject.Models;

namespace ponyproject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private VideoContext db = new VideoContext();

        public ActionResult Index()
        {
            return View(db.Videos);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
