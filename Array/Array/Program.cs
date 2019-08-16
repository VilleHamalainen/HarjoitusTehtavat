using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int i, amount;
            string[] hinta = { "3€", "4€", "5€" };
            string[] Hedelmat = { "Omena", "Mandariini", "Banaani" };
          /*  //T1
            amount = int.Parse(Console.ReadLine());

            for (i = 0; i < amount; i++)
            {
                Console.WriteLine(Hedelmat[i]);
            }


            //T2
            string input = Console.ReadLine();


            i = int.Parse(input);
            Console.WriteLine(Hedelmat[i] + " " + hinta[i]);
            Console.ReadKey();
            */
            //T3
            int 1, tuotteet;
            for(i = 0; i < tuotteet; i++)
            {
            
            Console.Write("Anna tuotteen 1. Nimi:  ");
            string Nimi1 = Console.ReadLine();
            Console.Write("Anna tuotteen 1. Hinta: ");
            decimal Hinta1 = decimal.Parse(Console.ReadLine());
            Console.Write("Anna tuotteen 1. Lukumäärä: ");
            int Lkm1 = int.Parse(Console.ReadLine());
            }




            

            Console.Write("\n");

            Console.Write("Anna tuotteen 2. Nimi: ");
            string Nimi2 = Console.ReadLine();
            Console.Write("Anna tuotteen 2. Hinta: ");
            decimal Hinta2 = decimal.Parse(Console.ReadLine());
            Console.Write("Anna tuotteen 2. Lukumäärä: ");
            int Lkm2 = int.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Anna tuotteen 3. Nimi: ");
            string Nimi3 = Console.ReadLine();
            Console.Write("Anna tuotteen 3. Hinta: ");
            decimal Hinta3 = decimal.Parse(Console.ReadLine());
            Console.Write("Anna tuotteen 3. Lukumäärä: ");
            int Lkm3 = int.Parse(Console.ReadLine());
            string[] TuoteNimi = { Nimi1, Nimi2, Nimi3 };
            decimal[] TuoteHinta = { Hinta1, Hinta2, Hinta3 };
            int[] TuoteLkm = { Lkm1, Lkm2, Lkm3 };

            Console.WriteLine("{0} {1} {2}", Nimi1, Hinta1, Lkm1);
            Console.WriteLine("{0} {1} {2}", Nimi2, Hinta2, Lkm2);
            Console.WriteLine("{0} {1} {2}", Nimi3, Hinta3, Lkm3);
            Console.ReadKey();




        }
    }
}
