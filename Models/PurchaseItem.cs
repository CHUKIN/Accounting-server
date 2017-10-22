using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting_server
{
    public class PurchaseItem 
    {
        [Key]
        [ForeignKey("Purchase"), Column(Order = 0)]
        public int PurchaseId {get;set;}
        public Purchase Purchase {get;set;}

        [Key]
        [ForeignKey("Item"), Column(Order = 1)]
        public int ItemId {get;set;}  
        public Item Item {get;set;}
        public decimal Count {get;set;}
        public bool Discount {get;set;}
        public int PriceId {get;set;}
        public Price Price {get;set;}
    }
}
