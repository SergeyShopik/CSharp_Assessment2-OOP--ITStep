using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public class Necklace
    {
        private GemstonesCollection gemstonesCollection;
        private SemipreciousCollection semipreciousCollection;
        private List<Stone> stones;
        public Necklace(GemstonesCollection g, SemipreciousCollection s)
        {
            gemstonesCollection = g;
            semipreciousCollection = s;
            stones = CreateListTotal();//initialize <stones> during object instantiation
        }

        public double CalcTotalWeight()
        {
            double weight = 0;

            foreach (Gemstone g in gemstonesCollection)
            {
                weight += g.Carat;
            }
            foreach (SemipreciousStone s in semipreciousCollection)
            {
                weight += s.Carat;
            }

            return weight;
        }
        public double CalcTotalPrice()
        {
            double price = 0;

            foreach (Gemstone g in gemstonesCollection)
            {
                price += g.Price;
            }
            foreach (SemipreciousStone s in semipreciousCollection)
            {
                price += s.Price;
            }

            return price;
        }

        //create list of all stones in the necklace
        private List<Stone> CreateListTotal()
        {
            stones = new List<Stone>();
            for (int i = 0; i < gemstonesCollection.gemstones.Length; i++)
            {
                stones.Add(gemstonesCollection.gemstones[i]);
            }
            for (int i = 0; i < semipreciousCollection.semiprecStones.Length; i++)
            {
                stones.Add(semipreciousCollection.semiprecStones[i]);
            }
            return stones;
        }
        public void SortPrice()
        {
            stones = CreateListTotal();
            for (int i = 1; i < stones.Count; i++)
            {
                Stone st = stones[i];
                double price = st.Price;
                bool flag = true;
                for (int j = i - 1; j >= 0 && flag;)
                {
                    if (price < stones[j].Price)
                    {
                        stones[j + 1] = stones[j];
                        j--;
                        stones[j + 1] = st;
                    }
                    else flag = false;
                }
            }
        }
        public void PrintAllStones()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                Console.WriteLine(stones[i]);
            }
        }

        //create list of stones in the given price margins
        public List<Stone> FindWithinPriceRange(double min, double max)
        {
            List<Stone> result = new List<Stone>();

            foreach (Stone s in stones)
            {
                if (s.Price > min && s.Price < max)
                {
                    result.Add(s);
                }
            }

            return result;
        }
    }
}
