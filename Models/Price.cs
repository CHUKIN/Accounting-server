using System;
using System.Collections.Generic;

namespace Accounting_server
{
    public class Price 
    {
        public int PriceId {get;set;}
        public decimal Cost {get;set;}
        public DateTime Date {get;set;}
        public int ItemId {get;set;}
        public Item Item {get;set;}
        public int ShopId {get;set;}
        public Shop Shop {get;set;}
        public List<PurchaseItem> PurchaseItems {get;set;}
    }
}
