using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            int result = 0;

            //T.1
            while (sum <= 100)
            {
                Console.Write("Anna luku: ");
                sum += int.Parse(Console.ReadLine());
            }
            
                Console.WriteLine("Raja ylitetty");
            //T.2
            while (result != 45)
            {
                string L = Console.ReadLine();
                if (L == "L")
                {
                    Console.WriteLine("yeet");
                    break;

                }

                result = int.Parse(L);
                Console.WriteLine("Yeet2");
            }
            Console.ReadKey();




        }
    }
}
