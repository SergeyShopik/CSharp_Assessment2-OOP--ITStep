using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public class SemipreciousCollection : IEnumerable
    {
        public SemipreciousStone[] semiprecStones;

        //constructor takes existing array of stones as an argument
        //and initializes collection
        public SemipreciousCollection(SemipreciousStone[] array)
        {
            semiprecStones = array;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public SemipreciousCollectionIterator GetEnumerator()
        {
            return new SemipreciousCollectionIterator(semiprecStones);
        }
    }
}
