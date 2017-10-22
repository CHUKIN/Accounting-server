using System;
using System.Collections.Generic;

namespace Accounting_server
{
    public class Purchase 
    {
        public int PurchaseId {get;set;}
        public string Descriprion {get;set;}
        public DateTime Date {get;set;}
        public int ShopId {get;set;}
        public Shop Shop {get;set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public bool DiscountProgramm {get;set;}
        public List<PurchaseItem> PurchaseItems {get;set;}
    }
}
