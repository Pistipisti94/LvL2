using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // A szamok.txt fájl beolvasása és listába tárolása
        List<int> szamok = new List<int>();
        using (StreamReader reader = new StreamReader("C:\\Users\\Demeter.Istvan.Tamas.BURG\\source\\repos\\LvL2\\Lista feladat\\bin\\Debug\\szamok.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int szam;
                if (int.TryParse(line, out szam))
                {
                    szamok.Add(szam);
                }
            }
        }

        // Legnagyobb szám és sorszáma
        int max = szamok.Max();
        int index = szamok.IndexOf(max);

        Console.WriteLine("A legnagyobb szám: " + max);
        Console.WriteLine("A legnagyobb szám sorszáma: " + index);

        Console.ReadLine();
    }
}
