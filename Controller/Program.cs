using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp_Assessment2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //price margins for finding stones in the price range
            const double MIN_PRICE = 110;
            const double MAX_PRICE = 900;

            //create gemstones collection
            Gemstone[] gemstones = new Gemstone[]
            {
                new Gemstone("pearl", 5, 800, 88),
                new Gemstone("diamond", 1, 1000, 95)
            };
            GemstonesCollection gc = new GemstonesCollection(gemstones);

            //create semipreicous stones collection
            SemipreciousStone[] semipreciousStones = new SemipreciousStone[]
            {
                new SemipreciousStone("hibonite", 6, 100, "high" ),
                new SemipreciousStone("beryl", 8, 120, "middle")
            };
            SemipreciousCollection sc = new SemipreciousCollection(semipreciousStones);


            Necklace necklace = new Necklace(gc, sc);
            Console.WriteLine("All stones sorted by price: ");
            necklace.SortPrice();
            necklace.PrintAllStones();

            double weight = necklace.CalcTotalWeight();
            double price = necklace.CalcTotalPrice();
            Console.WriteLine($"\nWeight: {weight} carats, Price: {price}$\n");

            List<Stone> stonesWithinPriceRange =
            necklace.FindWithinPriceRange(MIN_PRICE, MAX_PRICE);
            Console.WriteLine($"Stones between {MIN_PRICE}$ and {MAX_PRICE}$:");
            Printer.Print(stonesWithinPriceRange);
        }
    }
}
