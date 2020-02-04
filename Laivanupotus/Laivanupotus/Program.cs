using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Laivanupotus
{
    class Program
    {
        static void Shoot(int[,] AILauta, int rowLength, int colLength)
        {loopX:
            Console.Clear();
            Board(AILauta, rowLength, colLength, true);
            Console.Write("Enter X: ");
            bool successX = int.TryParse(Console.ReadLine(), out int inputX);
            if (!successX || inputX < 0 || inputX > 4)
                goto loopX;
            Console.Clear();
            loopY:
            Console.Write("Enter Y: ");
            bool successY = int.TryParse(Console.ReadLine(), out int inputY);
            if (!successY || inputY < 0 || inputY > 4)
                goto loopY;
            switch (AILauta[inputX, inputY])
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("You missed!");
                    AILauta[inputX, inputY] = 3;
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("You hit a ship!");
                    AILauta[inputX, inputY] = 2;
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You have sunken that ship already!");
                    goto loopX;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You have already shot there!");
                    goto loopX;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    goto loopX;
            }
        }
        static void AIShoot(int[,] Lauta)
        {
            Random random = new Random();
            addXloop:
                int randomX = random.Next(0, 5);
                int randomY = random.Next(0, 5);
                if (Lauta[randomX, randomY] == 2 || Lauta[randomX, randomY] == 3)
                {
                    goto addXloop;
                }
            switch (Lauta[randomX, randomY])
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Player 2 Missed");
                    Lauta[randomX, randomY] = 3;
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Player 1 got hit!");
                    Lauta[randomX, randomY] = 2;
                    break;
            }
                Console.Clear();
        }
        static int[,] AddShips(int[,] Lauta)
        {
            for (int i = 0; i < 3; i++)
            {
                addXloop:
                Console.Clear();
                Console.WriteLine("Add the ship's coordinates");
                Console.Write("Enter X of ship {0}: ", i + 1);
                bool successX = int.TryParse(Console.ReadLine(), out int addX);
                if (!successX || addX < 0 || addX > 4)
                    goto addXloop;
                addYloop:
                Console.Clear();
                Console.Write("Enter Y of ship {0}: ", i + 1);
                bool successY = int.TryParse(Console.ReadLine(), out int addY);
                if (!successY || addX < 0 || addX > 4)
                    goto addYloop;
                if (Lauta[addX, addY] == 1)
                {
                    Console.Clear();
                    Console.Write("There's already a ship there\n");
                    goto addXloop;
                }
                Console.Clear();
                Lauta[addX, addY] = 1;
            }
            return Lauta;
        }
        static int[,] AIaddShips(int[,] AILauta)
        {
            Random random = new Random();
            for(int i = 0; i < 3; i++)
            {
                addXloop:
                int randomX = random.Next(0, 5);
                int randomY = random.Next(0, 5);
                if (AILauta[randomX, randomY] == 1)
                {
                    goto addXloop;
                }
                AILauta[randomX, randomY] = 1;
                Console.Clear();
            }
            return AILauta;
            }
        static void Board(int[,] tulostettavaLauta, int rowLength,int colLength, bool ai)
        { //tulostaa pelaajan laudan
            if(ai)
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                if(tulostettavaLauta[i, j] == 1)
                {
                Console.Write("0 ");
                }
                else Console.Write("{0} ", tulostettavaLauta[i, j]);
                }
                Console.WriteLine();
            }
            else
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write("{0} ", tulostettavaLauta[i, j]);
                    }
                    Console.WriteLine();
                }
        }
        static void Player1Win(int[,] AILauta )
        {
            int shipsHit = 3;
            foreach (int ruutu in AILauta)
            {
                if (ruutu == 2)
                {
                    shipsHit--;
                }
            }
            if (shipsHit == 0)
            {
                Console.Clear();
                Console.WriteLine("Player 1 won the game");
            }
        }
        static void Player2Win(int[,] Lauta)
        {
            int shipsHit = 3;
            foreach(int ruutu in Lauta)
            {
                if (ruutu == 2)
                {
                    shipsHit--;
                }
            } 
            if(shipsHit == 0)
            {
                Console.Clear();
                Console.WriteLine("Player 2 / AI won the game");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        static void Main(string[] args)
        {
            //0 Is empty, 1 is a ship, 2 is a hit, 3 is a miss
            int[,] Lauta = new int[5, 5];
            int rowLength = Lauta.GetLength(0);
            int colLength = Lauta.GetLength(1);
            int[,] AILauta = new int[5, 5];
            int AIrowLength = Lauta.GetLength(0);
            int AIcolLength = Lauta.GetLength(1);
            
            Board(Lauta,rowLength,colLength, false);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Lauta = AddShips(Lauta);
            Board(Lauta, rowLength, colLength, false);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            AILauta = AIaddShips(AILauta);
            for(int i = 0; i < 30; i++)
            {
                Console.Clear();
                Shoot(AILauta, rowLength, colLength);
                Board(AILauta, colLength, rowLength, true);
                Console.ReadKey();
                Console.Clear();
                AIShoot(Lauta);
                Board(Lauta, colLength, rowLength, false);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Player1Win(AILauta);
                Player2Win(Lauta);
            }  
        }
    }
}
