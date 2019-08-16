using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laske
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int n = 5;
            for (j = 0; j < 11; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, j, n * j);
            }
        }
    }
}
