using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace huutokauppa
{
    class Program
    {

        enum Menu { lisaaEsine = 1, naytaEsineet, myyEsine, poistu }
        static void Main(string[] args)
        {
            Menu valinta; int sold = 0, itemCount = 0, sellingitem=0; int previousValue = 0, input=0, tavoite, maxHinta=0;
            List<string> esineNimi = new List<string>();
            List<int> Hinta = new List<int>();
            List<int> myytyHinta = new List<int>();
            bool jatka=true;

            Console.Write("Aseta huutokaupalle rahatavoite");
                tavoite = int.Parse(Console.ReadLine());

            while (jatka)
            {
                if(myytyHinta.Count > 0)
                maxHinta = myytyHinta.Max();
                
                previousValue = 0;
                Console.Clear();
                Console.Write("Korkein saatu hinta: ", maxHinta);
                Console.Write("Myytyjen esineitten määrä {0}\n\n", sold);
                
                Console.Write("1. Lisää myytäviä tuotteita.\n2. Näytä esineet.\n3. Myy esineitä.\n4. Poistu.\n>");
                
                while (true)
                {
                    try { valinta = (Menu)int.Parse(Console.ReadLine()); }
                    catch
                    {
                        Console.WriteLine("Syöttövirhe");
                        continue;
                    }
                    break;
                }

                Console.Clear();
                switch (valinta)
                {
                    case Menu.lisaaEsine:

                        while (true)
                        {
                            Console.Write("Esineen nimi: ");
                            try
                            {
                                esineNimi.Add(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Syöttö virhe");
                                continue;
                            }
                            break;
                        }

                        while(true)
                        {
                            Console.Write("Lisää aloitushinta (euro): ");
                            try { Hinta.Add(int.Parse(Console.ReadLine())); }
                            catch
                            {
                            Console.WriteLine("Syöttävirhe");
                            continue;
                            }
                            break;
                        }
                        itemCount++;
                        break;
                    case Menu.naytaEsineet:
                       
                        for (int i = 0; i < itemCount; i++)
                        {
                            if (i == 0)
                            { Console.Write(""); }
                            Console.WriteLine("EsineID: {0}", i);
                            Console.WriteLine("Esine: {0}", esineNimi[i]);
                            Console.WriteLine("Hinta: {0} euroa", Hinta[i]);
                            
                            Console.Write("\n");
                        }

                        Console.ReadKey();

                        break;
                    case Menu.myyEsine:
                        while(true)
                        {
                            Console.Write("Myynnissä tällä hetkellä: {0}\n",esineNimi[sellingitem]);
                            Console.Write("Esineen aloitushinta on: {0} euroa.\n", Hinta[sellingitem]);
                            Console.Write("\n");


                            previousValue = Hinta[sellingitem];
                                while (true)
                                {
                               
                                Console.WriteLine("Tämänhetkinen korkein tarjous on {0}", previousValue);
                                Console.Write("Uusi hintatarjous: ");
                                    bool success = int.TryParse(Console.ReadLine(), out input);
                                    if (!success) { continue; }

                                        if (input <= previousValue && input > 0)
                                    {
                                    Console.Clear();
                                    Console.WriteLine("Tarjous on liian pieni.");
                                        continue;
                                    }
                                        if (input == 0)
                                    {
                                        Console.Clear();
                                        Console.Write("Esine myyty korkeimmalle tarjoukselle. ");
                                    myytyHinta[sellingitem] = previousValue;
                                        Console.ReadKey();
                                        sold++;
                                        break;
                                    }
                                Console.Clear();
                                previousValue = input;
                                }  
                            break;
                        }
                        sellingitem++;
                        break;
                    case Menu.poistu:
                        Console.WriteLine("Isoin hinta yhdestä artikkelista: {0}", maxHinta);
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
