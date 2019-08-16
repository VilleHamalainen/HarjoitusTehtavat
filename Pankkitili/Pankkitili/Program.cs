using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pankkitili
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = 1500; 
            Console.Write("press any key to insert card.");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Card inserted.\n");
            Thread.Sleep(1500);

            Console.Write("Enter your card's pin: ");
            string pin = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                pin += key.KeyChar;
            }
            
         
            if (pin != "1234")
            {
                Console.Clear();
                Console.WriteLine("PIN is invalid.");
                goto pinInvalid;
            }
           
            Console.WriteLine("pin ok");
            Thread.Sleep(1000);

            Console.Write("Enter amount: ");
            int request = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Checking funds...");
            Thread.Sleep(1500);

            if(request > cash)
            {
                Console.Clear();
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sufficient funds.");
                Thread.Sleep(1500);
                Console.WriteLine("Transaction successful.");
                Thread.Sleep(1000);
            }
            pinInvalid:

            Console.Clear();
            Console.WriteLine("Ejecting card...");
            Thread.Sleep(1000);

            Console.WriteLine("Take the card.");


           


            Console.ReadKey();
        }
    }
}
