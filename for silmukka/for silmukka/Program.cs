using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i, x, arvonta, luku, kierros;
            Console.Write("Kirjoita numero: ");
             x = int.Parse(Console.ReadLine());
            Console.Clear();
            for ( i = x; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();

            Console.Write("Kirjoita numero: ");
            int a = int.Parse(Console.ReadLine());
            for (int b = 1; b <= 10; b++)

            {
                Console.WriteLine("{0} * {1} = {2}   {3} / {4} = {5}   {6} % {7} = {8}", a, b, a * b, a, b, a / b, a, b, a % b);
            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("Kirjoita numero: ");
            int n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++) {

                for (j = 1; j <= i; j++)
                { 
                    Console.Write( "{0} ", j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
            Random rnd = new Random();
            arvonta = rnd.Next(1, 20);
            for (kierros = 1; kierros <= 5; kierros++)
            {
                Console.Write("Kirjoita lukusi: ");
                luku = int.Parse(Console.ReadLine());
                if (luku == arvonta)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    break;
                }
                else Console.WriteLine("Yritä uudelleen");

            }
            Console.ReadKey();
        }
    }
}
