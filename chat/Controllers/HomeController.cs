using System.Web.Mvc;

namespace chat.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Chat()
        {

            if (Session["user"] == null) return RedirectToAction("Login", "User");
            return View();

        }
    }
}