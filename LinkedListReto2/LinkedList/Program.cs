using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReto2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lista = new LinkedList();

            lista.add(1);
            lista.add(4);
            lista.add(3);
            lista.add(7);

            Console.WriteLine("El tamaño de la lista es: " + lista.getSize());

            Iterator it = lista.getIterator();
            ReverseIterator it2 = lista.getReverseIterator();

            Console.WriteLine("-------------------");

            while (it.hasNext())
            {
                Iterator backupIt = new Iterator(it);
                int element = it.next();

                if (element == 3)
                {
                    lista.insert(10, LinkedList.BEFORE, backupIt);
                }

                if (element == 7)
                {
                    lista.insert(15, LinkedList.AFTER, backupIt);
                }

                Console.WriteLine("Dato: " + element);
            }


            Console.WriteLine("-------------------");
            it = lista.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

        }
    }
}

