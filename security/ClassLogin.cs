using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_iti_wpf_market.security
{
    internal class ClassLogin
    {
     public int ID { get; set; }
     public string pass { get; set; }
     public string Name { get; set; }
     //public string email { get; set; }
     //public string phone { get; set; }
     //public string address { get; set; }

        public ClassLogin(int iD, string pass, string name) 
        {
            ID = iD;
            this.pass = pass;
            Name = name;
            //this.email = email;
            //this.phone = phone;
            //this.address = address;
        }
    }


}
