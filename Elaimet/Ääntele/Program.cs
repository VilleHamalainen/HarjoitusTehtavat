using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Ääntele
{
    class Program
    {
        static void Main(string[] args)
        {

            Kissa katti = new Kissa();
            Koira musti = new Koira();

            
            katti.Aantele();
            musti.Aantele();
            Console.ReadKey();
        }
    }
}
