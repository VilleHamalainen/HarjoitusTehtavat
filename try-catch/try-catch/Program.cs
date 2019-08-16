using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Kirjoita Jakaja: ");
                int input1 = int.Parse(Console.ReadLine());
                Console.Write("Kirjoita jaettava: ");
                int input2 = int.Parse(Console.ReadLine());
                int result = input1 / input2;
                Console.WriteLine("Vastaus on {0}", result);
                

            }
            catch
            {
                
            }
            Console.WriteLine("Kiitos että pelasit!");
            Console.ReadKey();

        }
    }
}
