using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helikopteri
{
    class Program
    {

        enum Menu { uusihenkilo = 1, naytatiedot, poistu };
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> luggage = new List<int>();
            List<string> weight = new List<string>();

            int i = 0;
            int matkatavara = 0;
            menu:
            Console.Write("1. Uusihenkilo\n2. naytatiedot\n3. poistu\n");
            
            Menu valinta = (Menu)int.Parse(Console.ReadLine());
            switch (valinta)
            {
                case Menu.uusihenkilo:
                    whileloop:
                   
                    while (i < 4 && matkatavara < 100)
                    {

                        if (i > 0)
                        {
                            Console.Write("haluatko palata valikkoon? (yes/no): ");
                            string input2 = Console.ReadLine();
                            if (input2 == "yes")
                            {
                                goto menu;
                            }
                            else

                            Console.Write("Kirjoita henkilön nimi: ");
                            names.Add(Console.ReadLine());
                            i++;
                            Console.Write("Haluatko lisätä matkatavaroita (k/e/lopeta): ");
                            string input = Console.ReadLine();
                            if (input == "k")
                            {
                                luggage.Add(i);
                                Console.Write("Kirjoita laukun paino: ");
                                weight.Add(Console.ReadLine());

                            }
                            else if (input == "lopeta")
                            {
                                goto menu;
                            }
                            else if (input == "e")
                            {
                                goto whileloop;
                            }
                            else continue;
                        }
                        else
                        {
                            Console.Write("Kirjoita henkilön nimi: ");
                            names.Add(Console.ReadLine());
                            i++;
                            Console.Write("Haluatko lisätä matkatavaroita (k/e/lopeta): ");
                            string input = Console.ReadLine();
                            if (input == "k")
                            {
                                luggage.Add(i);
                                Console.Write("Kirjoita laukun paino: ");
                                weight.Add(Console.ReadLine());

                            }
                            else if (input == "lopeta")
                            {
                                goto menu;
                            }
                            else if (input == "e")
                            {
                                goto whileloop;
                            }
                            else continue;
                        }
                    }

                    goto menu;
                
                case Menu.naytatiedot:
                   for (i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Nimi: " + names[i]);
                            Console.WriteLine("Matkatavaran paino: " + weight[i] + "kg");
                            Console.Write("\n");
                        }
                        Console.ReadKey();
                        goto menu; 
                    
                case Menu.poistu:

                    break;
                default:
                    break;
            }; 


        }
    }
}
