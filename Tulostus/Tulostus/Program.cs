using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ree");
            Console.Write("Kirjoita nimesi: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hei {0}!", name);
            Console.ReadKey();
        }
    }
}
