using System.Collections.Generic;

namespace Accounting_server
{
    public class Item 
    {
        public int ItemId {get;set;}
        public string Name {get;set;}
        public List<Price> Prices {get;set;}
        public List<PurchaseItem> PurchaseItems {get;set;}
    }
}
