using Microsoft.AspNetCore.Mvc;
 
namespace Accounting_server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}