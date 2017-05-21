using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using IdentitySample.Models;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            
            ViewBag.Message = User.Identity.GetUserId();

            return View();
        }

        [Authorize(Roles = "User")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
