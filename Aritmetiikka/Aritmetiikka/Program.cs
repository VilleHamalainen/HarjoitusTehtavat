using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetiikka
{
    class Program
    {
        static class MenuCounter
        {
            public static int corCounter;
        }

        public static void Yhteenlasku(bool negative, int max, List<int> numbers, bool success, string answer, int corCounter)
        {
            bool exit = false;
            while (exit == false)
            {
                
                RandomNumber(negative, max, numbers);
                Console.WriteLine("What is {0} + {1}        Type 'Exit' to go back to the menu", numbers[0], numbers[1]);
                int correctAnswer = numbers[0] + numbers[1];
                success = false;

                while (true)
                {
                    answer = Console.ReadLine().ToLower();

                    if (answer == "exit")
                    {
                        exit = true;
                        break;
                    }
                    
                    else
                    {
                        success = double.TryParse(answer, out double numberAnswer);
                        Incor(correctAnswer, numberAnswer, corCounter);
                        break;
                    }
                }
            }
            return;
        }

        public static void Vahennyslasku(bool negative, int max, List<int> numbers, bool success, string answer, int corCounter)
            {
            bool exit = false;
            while (exit == false)
            {
                RandomNumber(negative, max, numbers);
                Console.WriteLine("What is {0} - {1}        Type 'Exit' to go back to the menu", numbers[0], numbers[1]);
                int correctAnswer = numbers[0] - numbers[1];
                success = false;
                while (success == false)
                {
                    answer = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (answer == "exit")
                    { 
                        exit = true;
                        break;
                    }
                    else
                    {
                        success = double.TryParse(answer, out double numberAnswer);
                        Incor(correctAnswer, numberAnswer, corCounter);
                        break;
                    }
                }
            }
            return;
            }

        public static void Kertolasku(bool negative, int max, List<int> numbers, bool success, string answer, int corCounter)
        {
            bool exit = false;

            while (exit == false)
            {
                RandomNumber(negative, max, numbers);
                Console.WriteLine("What is {0} * {1}        Type 'Exit' to go back to the menu", numbers[0], numbers[1]);
                int correctAnswer = numbers[0] * numbers[1];
                success = false;
                while (success == false)
                {
                    answer = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (answer == "exit")
                    {
                        exit = true;
                        break;
                    }
                    else
                    {
                        success = double.TryParse(answer, out double numberAnswer);
                        Incor(correctAnswer, numberAnswer, corCounter);
                        break;
                    }
                }
            }
            return;
        }

        public static void Jakolasku(bool negative, int max, List<int> numbers, bool success, string answer, int corCounter)
        {
            bool exit = false;
            while (exit == false)
            {
                RandomNumber(negative, max, numbers);
                Console.WriteLine("What is {0} / {1}        Type 'Exit' to go back to the menu", numbers[0], numbers[1]);
                double yebat = (double)numbers[0] / (double)numbers[1];
                double correctAnswer = Math.Round(yebat, 2);
                success = false;
                while (success == false)
                {
                    answer = Console.ReadLine().ToLower();

                    Console.Clear();
                    if (answer == "exit")
                    {
                        exit = true;
                        break;
                    }
                    else
                    {
                        success = double.TryParse(answer, out double numberAnswer);
                        Incor(correctAnswer, numberAnswer, corCounter);
                        break;
                    }
                }
            }
            return;
        }

        static void Incor(double correctAnswer, double numberAnswer, int corCounter)
        {
            if (numberAnswer == correctAnswer)
            {
                Console.WriteLine("Correct");
                MenuCounter.corCounter++;
            }
            else
                Console.WriteLine("Incorrect");
        }

        static public List<int> RandomNumber(bool negative, int max, List<int> numbers)
        {

            Random random = new Random();
            int num1 = random.Next(1, max);
            int num2;
            numbers.Add(0);
            numbers.Add(0);
            numbers[0] = num1;

            if (negative == false)
            {
                num2 = random.Next(1, num1);
                numbers[1] = num2;
            }
            else
            {
                num2 = random.Next(1, max);
                numbers[1] = num2;
            }

            return numbers;

        }

        static public int Max(int max, bool success)
        {
            success = false;
            while (success == false)
            {
                Console.Clear();
                Console.WriteLine("Write the Max number for the game.");
                success = int.TryParse(Console.ReadLine(), out max);
                if (max > 0)
                    success = true;
                else
                    success = false;

            }
            return max;
        }

        static public bool Negative(bool success, bool negative)
        {
            success = false;
            while (success == false)
            {
                Console.Clear();
                Console.WriteLine("Can the answer be negative? true/false");
                success = bool.TryParse(Console.ReadLine(), out negative);
            }
            return negative;
        }

        static public int DrawMenu(bool success, int caseSwitch)
        {
            Console.Clear();
            Console.Write("Oikeat vastaukset: {0}\n\n1. Yhteenlasku\n2. Vähennyslasku\n3. Kertolasku\n4. Jakolasku\n5. Poistu\n\n>", MenuCounter.corCounter);
            success = false;
            while (success == false)
                success = int.TryParse(Console.ReadLine(), out caseSwitch);

            return caseSwitch;
        }

        enum Menu { yhteenlasku = 1, vähennylasku = 2, kertolasku = 3, jakolasku = 4, poistu = 5 }

        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            int max = 0, caseSwitch = 0;
            bool success = false, negative = false; 
            string answer="";

            Max(max, success);
            negative = Negative(success, negative);
            
            while (true)
            {
                caseSwitch = DrawMenu(success, caseSwitch);

                switch (caseSwitch)
                {
                    
                   case (int)Menu.yhteenlasku:
                        {
                            Yhteenlasku(negative, max, numbers, success, answer, MenuCounter.corCounter);
                            break;
                        }
                        
                    case (int)Menu.vähennylasku:
                        {
                            Vahennyslasku(negative, max, numbers, success, answer, MenuCounter.corCounter);
                            break;
                        } 
                    case (int)Menu.kertolasku:
                        {
                            Kertolasku(negative, max, numbers, success, answer, MenuCounter.corCounter);
                            break;
                        }
                    case (int)Menu.jakolasku:
                        {
                            Jakolasku(negative, max, numbers, success, answer, MenuCounter.corCounter);
                            break;
                        }
                        
                    case (int)Menu.poistu:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            } 
        }
    }
}
