using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loogiset_Operaattorit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Paistaako aurinko(K/E): ");
            string k1 = Console.ReadLine();
            Console.Clear();
            Console.Write("Sataako(K/E): ");
            string k2 = Console.ReadLine();
            Console.Clear();
            Console.Write("Onko lämpötila >0(K/E): ");
            string k3 = Console.ReadLine();
            Console.Clear();
            if(k1 == "K" && k2 == "K" && k3 == "K")
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa taitaa tulla kesä.");
            }
            else if (k1 == "E" && k2 == "K" && k3 == "K")
                {
                Console.WriteLine("Syksy saapui lehdet vei tuuli menneessään.");
            }
            else if (k1 == "E" && k2 == "E" && k3 == "K" || k1 == "K" && k2 == "E" && k3 == "K")
                {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
            }
            else if (k1 == "E" && k2 == "K" && k3 == "E")
            {
                Console.WriteLine("(EKE) En keksiny mitään järkevää");
            }
            else if (k1 == "K" && k2 == "E" && k3 == "E")
            {
                Console.WriteLine("(KEE) EN keksiny mitään järkevää");
            }
            else if (k1 == "E" && k2 == "E" && k3 == "E")
            {
                Console.WriteLine("(EEE) EN keksinyt mitään järkevää");
            }
            Console.ReadKey();
        }
    }
}
