using Microsoft.AspNetCore.Mvc;


namespace ÜritusedWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult Error()
        {
            return null;
        }
    }
}
