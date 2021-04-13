using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_2
{
    public class ArrayList<H> : List<H>
    {

        private Object[] array;
        internal int size;

        public ArrayList()
        {
            this.array = new Object[2];
        }

        public void add(H data)
        {
            if (size == array.Length)
            {
                Object[] arrayAux = new Object[array.Length + 2];

                for (int i = 0; i < array.Length; i++)
                {
                    arrayAux[i] = array[i];
                }

                this.array = new Object[arrayAux.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = arrayAux[i];
                }
            }
            this.array[size] = data;
            size++;
        }

        public H get(int index)
        {
            return (H)array[index];
        }

        public void delete(int index)
        {
            for (int i = index + 1; i < size; i++)
            {
                array[i - 1] = array[i];
            }
            size--;
        }

        public int getSize()
        {
            return size;
        }

        public Iterator<H> getIterator()
        {
            return new ForwardIterator(this);
        }

        public Iterator<H> getReverseIterator()
        {
            return new ReverseIterator(this);
        }

        public void insert(H data, Position position, Iterator<H> it)
        {

        }

        public class ForwardIterator : Iterator<H>
        {
            private ArrayList<H> arrayList;
            private int currentIndex;

            public ForwardIterator(ArrayList<H> arrayList)
            {
                this.arrayList = arrayList;
                this.currentIndex = 0;
            }

            public bool hasNext()
            {
                return currentIndex < arrayList.size;
            }

            public H next()
            {
                return (H)arrayList.array[currentIndex++];
            }
        }

        public class ReverseIterator : Iterator<H>
        {
            private ArrayList<H> arrayList;
            private int currentIndex;

            public ReverseIterator(ArrayList<H> arrayList)
            {
                this.arrayList = arrayList;
                this.currentIndex = arrayList.size - 1;
            }

            public bool hasNext()
            {
                return currentIndex >= 0;
            }

            public H next()
            {
                return (H)arrayList.array[currentIndex--];
            }
        }

    }
}