using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public class Gemstone : Stone
    {
        private double Purity { get; set; }

        public Gemstone()
        {

        }
        public Gemstone(string name, double carat, double price, double purity)
            : base(name, carat, price)
        {
            Purity = purity;
        }

        public override string ToString()
        {
            return $"Gemstone name: {Name}, carat: {Carat}, price: {Price}$, " +
                $"purity: {Purity}%";
        }
    }
}
