using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    //all types of stones inherit from Stone class
    public class Stone
    {
        public string Name { get; set; }
        public double Carat { get; set; }
        public double Price { get; set; }

        public Stone()
        {

        }
        public Stone(string name, double carat, double price)
        {
            Name = name;
            Carat = carat;
            Price = price;
        }
    }
}
