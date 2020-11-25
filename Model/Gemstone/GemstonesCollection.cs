using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assessment2_OOP
{
    public class GemstonesCollection : IEnumerable
    {
        public Gemstone[] gemstones;

        public GemstonesCollection(Gemstone[] array)
        {
            gemstones = new Gemstone[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                gemstones[i] = array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public GemstonesCollectionIterator GetEnumerator()
        {
            return new GemstonesCollectionIterator(gemstones);
        }
    }
}
