using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace funktiot

{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kirjoita luku johon fibonacci loppuu: ");
          int max = int.Parse(Console.ReadLine());

            int value1 = 0;
            int value2 = 1;
            int value3 = 0;
            Console.Write("{0}\n{1}\n", value1, value2);
            while(value3 < max)
            {
                value3 = value1 + value2; 
                if(value3 < max)
                Console.WriteLine(value3);
                value1 = value2;
                value2 = value3;
                
            }
            Console.ReadKey();
            
        }
    }
}