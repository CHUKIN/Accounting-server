using System.Collections.Generic;

namespace Accounting_server
{
    public class Shop
    {
        public int ShopId {get;set;}
        public string Name {get;set;}
        public List<Price> Prices {get;set;}
        public List<Purchase> Purchase {get;set;}
    }
}
