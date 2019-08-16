using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopanheitto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, summa = 0;

            Console.WriteLine("Heitä nopat 5 kertaa painamalla mitä tahansa näppäintä..");
            Console.ReadKey();

            for (i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("\n");
                Random dice = new Random();
                int dice1 = dice.Next(1, 7);
                int dice2 = dice.Next(1, 7);
                summa += dice1 + dice2;

                switch (dice1)
                {
                    case 1:
                        DiceFace1();
                        break;
                    case 2:
                        DiceFace2();
                        break;
                    case 3:
                        DiceFace3();
                        break;
                    case 4:
                        DiceFace4();
                        break;
                    case 5:
                        DiceFace5();
                        break;
                    case 6:
                        DiceFace6();
                        break;
                }          
                switch (dice2)
                {
                    case 1:
                        DiceFace1();
                        break;
                    case 2:
                        DiceFace2();
                        break;
                    case 3:
                        DiceFace3();
                        break;
                    case 4:
                        DiceFace4();
                        break;
                    case 5:
                        DiceFace5();
                        break;
                    case 6:
                        DiceFace6();
                        break;
                }
                Console.ReadKey();
                
            }
            Console.Clear();
            Console.WriteLine("Noppien silmälukujen summa on {0}", summa);
            Console.ReadKey();

            void DiceFace1()
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                Console.WriteLine(" ------- ");
            }
            void DiceFace2()
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|o      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      o|");
                Console.WriteLine(" ------- ");
            }
            void DiceFace3()
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|o      |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|      o|");
                Console.WriteLine(" ------- ");
            }
            void DiceFace4()
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|o     o|");
                Console.WriteLine("|       |");
                Console.WriteLine("|o     o|");
                Console.WriteLine(" ------- ");
            }
            void DiceFace5()
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|o     o|");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|o     o|");
                Console.WriteLine(" ------- ");
            }
            void DiceFace6()
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|o  o  o|");
                Console.WriteLine("|       |");
                Console.WriteLine("|o  o  o|");
                Console.WriteLine(" ------- ");
            }
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
