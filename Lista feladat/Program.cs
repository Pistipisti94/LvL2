using System;
using System.Collections.Generic;
using System.IO;

namespace Lista_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mennyi elemet generáljak? ");
            int mennyiseg = Convert.ToInt32(Console.ReadLine());

            Random random= new Random();

            int[] tomb = new int[mennyiseg];
     
            for (int i = 0; i < mennyiseg; i++)
            {
                
                tomb[i] = random.Next(1, 1000);
                
            }
            Console.WriteLine("File name? ");
            string name = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(name + ".txt"))
            {
                for (int i = 0; i < tomb.Length; i++)
                {
                    sw.WriteLine(tomb[i]);
                }

                sw.Close();
            }
            
            Console.ReadKey();
        }
    }
}
