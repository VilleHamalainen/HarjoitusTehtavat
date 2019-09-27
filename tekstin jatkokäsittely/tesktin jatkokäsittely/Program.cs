using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesktin_jatkokäsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char value = 'a';
            char[] array;
            array = input.ToCharArray();
            int numero = Array.IndexOf(array, value);
            if (numero > 0)
            {
                Console.Write("Kirjain a on {0} kirjain stringissä", numero + 1);
            }
            else Console.Write("Stringissä ei ole kirjainta a");
            
            
            Console.ReadKey();


        }
    }
}
