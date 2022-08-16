using Microsoft.AspNetCore.Mvc;

namespace Lab_One.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("one", "Hello i'm session Message");
            return Content("Session has been Set Successfully");
        }
        public IActionResult getSession()
        {
            if (HttpContext.Session.GetString("one") != null)
                return Content(HttpContext.Session.GetString("one"));
            else
                return Content("please set the session first");
        }
    }
}
