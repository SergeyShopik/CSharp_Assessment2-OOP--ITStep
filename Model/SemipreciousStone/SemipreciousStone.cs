using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    //semiprecious - полудрагоценный
    public class SemipreciousStone : Stone
    {
        private string Translucency { get; set; }
        public SemipreciousStone (string name, double carat, double price, string translucency)
            : base (name, carat, price)
        {
            Translucency = translucency;
        }

        public override string ToString()
        {
            return $"Semiprecious stone name: {Name}, carat: {Carat}, price: {Price}$, " +
                $"translucency: {Translucency}";
        }
    }
}
