using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
 
namespace Accounting_server.Controllers
{
    public class HomeController : Controller
    {
        private AccountingContext db;

        public HomeController(AccountingContext context)
        {
            db=context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string shopName, DateTime dateTime, string description, string[] itemName, decimal[] itemCost, decimal[] itemCount, string[] itemsDiscount)
        {
            Shop shop = db.Shops.FirstOrDefault(i=>i.Name==shopName);
            if(shop==null)
            {
                shop = new Shop{Name=shopName};
                db.Shops.Add(shop);
            }

            User user = db.Users.FirstOrDefault(i=>i.Login=="CHUKIN");

            Purchase purchase = new Purchase{Shop=shop,User=user,Date=dateTime, Descriprion=description};
            db.Purchases.Add(purchase);

            for(int i=0;i<itemName.Count();i++)
            {
                Item item = db.Items.FirstOrDefault(j=>j.Name==itemName[i]);
                if(item==null)
                {
                    item = new Item{Name=itemName[i]};
                    db.Items.Add(item);
                }

                bool discount = itemsDiscount.Contains(item.Name);

                Price price = new Price{Date=dateTime, Discount=discount, Cost=itemCost[i], Shop=shop, Item=item};
                db.Prices.Add(price);

                PurchaseItem purchaseItem = new PurchaseItem{Purchase=purchase, Item=item, Price=price, Count=itemCount[i]};
                db.PurchaseItems.Add(purchaseItem);
            }  

            db.SaveChanges();   

            return View();
        }
    }
}