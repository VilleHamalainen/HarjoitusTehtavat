using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkuluvut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kirjoita luku");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Kaikki antamaasi numeroa pienemmät alkuluvut:");
           
            for (int i = 2; i < input; i++)
            {
                int flag = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1; break;
                    }
                }

                if (flag == 0) Console.WriteLine(i); }



        }
    }
}
