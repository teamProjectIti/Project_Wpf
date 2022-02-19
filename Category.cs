using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_iti_wpf_market
{
   public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Describtions { get; set; }
        public Category(int iD, string name, string describtions)
        {
            ID = iD;
            Name = name;
            Describtions = describtions;
        }
        public Category()
        {

        }

    }
}
