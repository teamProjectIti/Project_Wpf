using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_iti_wpf_market.security
{
    internal class ClassUsers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address {get; set; }

        public ClassUsers(int iD, string name, string email, string phone, string address)
        {
            ID = iD;
            Name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }
    }
}
