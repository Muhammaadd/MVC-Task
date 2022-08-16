using Microsoft.AspNetCore.Mvc;

namespace Lab_One.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
