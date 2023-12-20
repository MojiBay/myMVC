using Microsoft.AspNetCore.Mvc;

namespace myMVC.Controllers
{
    public class startController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
