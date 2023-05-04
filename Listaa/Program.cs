using System;
using System.Collections.Generic;

namespace Listaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lista = new LinkedList<string>();

           
            
            //Hozzáadás
            lista.AddLast("a");
            lista.AddLast("b");
            lista.AddLast("c");
            lista.AddLast("d");

            //Balról bővítés
            lista.AddFirst("e");

            //Beszúrás
            lista.AddAfter(lista.Find("b"), "beszurasmoge");
            lista.AddBefore(lista.Find("a"), "beszurele");


            //lista elemek száma
            Console.WriteLine("Lista elemek száma: {0}", lista.Count);
           
            Console.WriteLine("A lista tartalma előre: ");

            foreach (string item in lista)
                Console.WriteLine("{0}",item);

            Console.WriteLine("\n Lista tartalma visszafele: ");
            var vissza = lista.Last;
            while (vissza != null)
            {
                Console.WriteLine("{0}", vissza.Value);
                vissza = vissza.Previous;

            }

            Console.ReadKey();
        }
    }
}
