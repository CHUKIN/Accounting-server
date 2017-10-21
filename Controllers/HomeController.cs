using Microsoft.AspNetCore.Mvc;
 
namespace EmptyApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}