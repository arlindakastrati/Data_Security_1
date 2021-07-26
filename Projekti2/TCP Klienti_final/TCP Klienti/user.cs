using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_TCP
{
    public class user
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string saltedHash { get; set; }
        public decimal invoicetype { get; set; }
        public string year { get; set; }
        public int month { get; set; }
        public string valueineuros { get;set;}
        public string valueindollar { get; set; }
    }
}