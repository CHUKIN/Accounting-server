using System.Collections.Generic;

namespace Accounting_server
{
    public class User
    {
        public int UserId {get;set;}
        public string Login {get;set;}
        public List<Purchase> Purchase {get;set;}
    }
}
