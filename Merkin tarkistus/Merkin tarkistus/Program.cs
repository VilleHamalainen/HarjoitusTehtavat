using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkin_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char merkki = Console.ReadKey().KeyChar;
            if (char.IsNumber(merkki))
            {
                Console.WriteLine("\nMerkkisi on numero: " + char.GetNumericValue(merkki));
            }
            else if(char.IsSymbol(merkki))
            {
                Console.WriteLine("\nMerkkisi on symboli: " + merkki);
            }
            else if (char.IsLetter(merkki))
            {
                Console.WriteLine("\nMerkkisi on kirjain: " + merkki);
            }
            else Console.WriteLine("\nKirjaimesi on tyhjää tai sitä ei tunnisteta");
           
            
           
            
            
            
            Console.ReadKey();
            


        }
        
    }
}
