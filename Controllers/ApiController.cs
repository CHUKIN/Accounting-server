using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Accounting_server.Controllers
{
    public class ApiController : Controller
    {
        private AccountingContext db;

        public ApiController(AccountingContext context)
        {
            db=context;
        }

        [HttpGet]
        public IActionResult Items()
        {
            return Json(db.Items.Include(i=>i.Prices).ThenInclude(p=>p.Shop).Select(i=>new {
                Name = i.Name,
                Cost = i.Prices.OrderByDescending(p=>p.Date).FirstOrDefault().Cost,
                Date = i.Prices.OrderByDescending(p=>p.Date).FirstOrDefault().Date,
                Shop = i.Prices.OrderByDescending(p=>p.Date).FirstOrDefault().Shop.Name,
            }));
        }
    }
}