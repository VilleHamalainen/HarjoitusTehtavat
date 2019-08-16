using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekstin_käsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            Console.Clear();
            char[] array = value.ToCharArray();
             Console.Write(value);
            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                Console.Write("{0} ", letter);


            }
            Console.Write("\n");
            for (int i = array.Length; i > 0; i--)
            {
                char letter = array[i - 1];
                
                Console.Write("{0} ", letter);
            }
            Console.ReadKey();
        }
    }
}
