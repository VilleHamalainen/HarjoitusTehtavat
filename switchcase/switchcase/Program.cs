using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            //T.1 
            success: 
            bool success = int.TryParse(Console.ReadLine(), out int value);
            if (!success || value < 1 || value > 7 )
            {
                Console.WriteLine("Invalid Input");
                goto success;
            }

            switch (value)
            {
                case 1:
                    Console.WriteLine("Maanantai");
                    break;
                case 2:
                    Console.WriteLine("Tiistai");
                    break;
                case 3:
                    Console.WriteLine("Keskiviikko");
                    break;
                case 4:
                    Console.WriteLine("Torstai");
                    break;
                case 5:
                    Console.WriteLine("Perjantai");
                    break;
                case 6:
                    Console.WriteLine("Lauantai");
                    break;
                case 7:
                    Console.WriteLine("Sunnuntai");
                    break;
            }
            Console.ReadKey();
            
        //T.2
        success2:
            bool success2 = int.TryParse(Console.ReadLine(), out int value2);
            if(!success2 || value2 < 4 || value2 > 10)
            {
                Console.WriteLine("Invalid input");
                goto success2;
            }

            switch (value2)
            {
                case 4:
                    Console.WriteLine("Hylätty");
                    break;
                case 5:
                    Console.WriteLine("5 on huono arvosana");
                    break;
                case 6:
                    Console.WriteLine("6 on välttävä arvosana");
                    break;
                case 7:
                    Console.WriteLine("7 on tyydyttävä arvosana");
                    break;
                case 8:
                    Console.WriteLine("8 on hyvä arvosana");
                    break;
                case 9:
                    Console.WriteLine("9 on kiitettävä arvosana");
                    break;
                case 10:
                    Console.WriteLine("10 on erinomainen arvosana");
                    break;

                    
            }
                Console.ReadKey();
        }
    }
}
