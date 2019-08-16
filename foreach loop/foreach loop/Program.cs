using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            foreach(int luku in array)
            {
                sum += luku; 
            }
            int avarage = sum / array.Length;
            Console.WriteLine(avarage);
            Console.ReadKey();
        }
    }
}

