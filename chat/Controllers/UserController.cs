using System.Web.Mvc;

namespace chat.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Submit_Login(string name)
        {
            Session["user"] = name;
            return RedirectToAction("Chat", "Home");
        }

    }

}