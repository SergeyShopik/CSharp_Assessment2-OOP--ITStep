using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public class GemstonesCollectionIterator : IEnumerator
    {
        public Gemstone[] gemstones;
        int position = -1; //initial position is before the first element

        public GemstonesCollectionIterator(Gemstone[] array)
        {
            gemstones = array;
        }

        public bool MoveNext()
        {
            position++;
            return (position < gemstones.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Gemstone Current
        {
            get
            {
                try
                {
                    return gemstones[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
