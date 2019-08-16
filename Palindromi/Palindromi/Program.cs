using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromi
{
    class Program
    {

        static void Main(string[] args)
        {
            string reverseWord = "";
            string input = Console.ReadLine();
            char[] charArray;

            input = input.ToLower();
            input = RemoveSpecialCharacters(input);

            charArray = input.ToCharArray();


            for (int i = charArray.Length; i > 0; i--)
            {
                reverseWord += charArray[i - 1];
            }

            if (input == reverseWord)
            {
                Console.Write("Palindromi");
            }
            else
            {
                Console.Write("ei palindromi");
            }
            Console.ReadKey();

            string RemoveSpecialCharacters(string str)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in str)
                {
                    if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'))
                        sb.Append(c);
                }
                return sb.ToString();
            }
        }
    }
}


