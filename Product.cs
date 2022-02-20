using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_iti_wpf_market
{
    public class Product
    {
        public int id { get; set; }



        public string name { get; set; }
        public int quantity { get; set; }



        public double price { get; set; }

        public string categoray { get; set; }

        public DateTime ExpiredDate { get; set; }

        public string store { get; set; }



        public Product()
        {

        }

    }
}

