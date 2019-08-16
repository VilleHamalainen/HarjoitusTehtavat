using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nimimaara;    
            List<String> Names = new List<String>();
            for(; ; )
            {
                Console.Write("Kirjoita oppilaan nimi: ");
                Names.Add(Console.ReadLine());
                tryagain:
                Console.WriteLine("Haluatko lisätä toisen oppilaan? Y/N");
                string newstudent = Console.ReadLine();
                if (newstudent == "N")
                {
                    break;
                }
                else if (newstudent == "Y")
                {
                    continue;
                }
                else goto tryagain;
            }
            order:
            Console.Write("Haluatko nähdä oppilaat aakkosten alku- vai loppupäästä (A/L): ");
            var jarjestys = Console.ReadLine();
            if (jarjestys == "A")
            {   
                Names.Sort();
                oppilasmaara:
                Console.Write("Kuinka monta oppilasta haluat nähdä: ");
                bool success = int.TryParse(Console.ReadLine(), out nimimaara);
                if (!success)
                {
                    Console.WriteLine("Invalid input");
                    goto oppilasmaara;
                }
                if (nimimaara > Names.Count)
                    nimimaara = Names.Count;
                for (i = 0; i <= nimimaara; i++)
                {
                    Console.WriteLine(Names[i]);
                }
            }
            else if (jarjestys == "L")
            {
                Names.Sort();
                Names.Reverse();
                oppilasmaara:
                Console.Write("Kuinka monta oppilasta haluat nähdä: ");
                bool success = int.TryParse(Console.ReadLine(), out nimimaara);
                if(!success)
                {
                    Console.WriteLine("Invalid input");
                    goto oppilasmaara;
                }
                if (nimimaara > Names.Count)
                    nimimaara = Names.Count;
                for (i = 0; i < nimimaara; i++)
                {
                    Console.WriteLine(Names[i]);
                    }
            }
            else goto order;
            Console.ReadKey();
        }
    }
}
