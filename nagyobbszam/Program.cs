using System;
using System.Collections.Generic;
using System.Linq;

namespace nagyobbszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fbc();
        }

        static int[] Fac(List<int> szamok)
        {
            int[] ints = new int[] { szamok.Min(), szamok.Max() };
            return ints;
        }

        static void Fbc()
        {
            List<int> list = new List<int>();
            Console.WriteLine("c) sorold fel a számokat, ha végeztél, nyomj 0-t");
            int item = int.Parse(Console.ReadLine());
            list.Add(item);
            while (item != 0)
            {
                list.Add(item);
                item = int.Parse(Console.ReadLine());
            }

            int[] max = Fac(list);
            Console.WriteLine($"A lista legnagyobb száma: {max[1]}\nA lista legkisebb száma: {max[0]}");
        }
    }
}
