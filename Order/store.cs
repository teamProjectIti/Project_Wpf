using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_iti_wpf_market
{
public class store
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }


        public store(string Name, string Address, string Phone)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;

        }

        public store(string name)
        {
            Name = name;
        }



    }
}
