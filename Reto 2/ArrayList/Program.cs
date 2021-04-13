using System;

namespace Reto_2
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<int> lista = new ArrayList<int>();
            List<string> lista2 = new ArrayList<string>();

            lista.add(1);
            lista.add(4);
            lista.add(3);
            lista.add(7);

            lista2.add("Hola");
            lista2.add("Object ");
            lista2.add("Oriented ");
            lista2.add("Programming ");

            Iterator<int> it = lista.getIterator();
            Iterator<string> it2 = lista2.getIterator();

            Console.WriteLine("El tamaño de la lista es: " + lista.getSize());

            Console.WriteLine("------------------------");

            it2 = lista2.getIterator();

            while (it2.hasNext())
            {
                string element = it2.next();

                Console.WriteLine("Dato: " + element);
            }


            Console.WriteLine("-----------------------");

            it = lista.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }
            Console.WriteLine("El tamaño de la lista es: " + lista.getSize());
        }
    }
}