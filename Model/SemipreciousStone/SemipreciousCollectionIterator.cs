using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public class SemipreciousCollectionIterator : IEnumerator
    {
        public SemipreciousStone[] semiprecStones;
        int position = -1; //initial Enumerator's position is before the first element

        public SemipreciousCollectionIterator(SemipreciousStone[] array)
        {
            semiprecStones = array;
        }

        //check is position within the range
        public bool MoveNext()
        {
            position++;
            return (position < semiprecStones.Length);
        }

        //provide Enumenator ability to start from the beginning of the range
        public void Reset()
        {
            position = -1;
        }

        //get an element at the current position of the Enumenator
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public SemipreciousStone Current
        {
            get
            {
                try
                {
                    return semiprecStones[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
