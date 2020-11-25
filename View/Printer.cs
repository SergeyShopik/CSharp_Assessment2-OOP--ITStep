using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public static class Printer
    {
        public static void Print(List<Stone> stones)
        {
            foreach (Stone s in stones)
            {
                Console.WriteLine(s);
            }
        }
    }
}
