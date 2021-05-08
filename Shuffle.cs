using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Typygeneryczne_zadanie_3
{
    public class Shuffle<T> :IEnumerable<T>
    {

        public T[] tab;
        public int size;

        public Shuffle(int size)
        {
            tab = new T[size + 1];
        }

        public void ArrayShuffle(T[] tab)
        {

            Random los = new Random();

            for (int i = size-1; i > 0; i--)
            {
                int j = los.Next(0, i + 1);

                T temp = tab[i];
                tab[i] = tab[j];
                tab[j] = temp;
                Console.WriteLine(j);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(tab[i]+ " ");
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)tab).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return tab.GetEnumerator();
        }
    }
}
