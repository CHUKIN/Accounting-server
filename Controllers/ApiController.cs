using System;
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
            return Json(db.Items);
        }

         [HttpGet]
        public IActionResult Shops()
        {
            return Json(db.Shops);
        }
    }
}