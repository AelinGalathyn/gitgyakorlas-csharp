using System;

namespace nagyobbszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fb();
        }

        static string Fa(int a, int b)
        {
            if (a > b)
            {
                return "a";
            }
            else
            {
                return "b";
            }
        }

        static void Fb()
        {
            Console.Write("b)\na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            string m = Fa(a, b);
            Console.WriteLine($"A nagyobb szám a(z) {m}");
        }
    }
}
