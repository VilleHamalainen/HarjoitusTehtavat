using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa: Nisakkaat //class name
    {
        private List<Kissa> pennut = new List<Kissa>();
        public Kissa()
        {

        }
        public Kissa(string nimi, int ika, int teeth, bool onLihanSyoja)
        {

        }

        public override void Aantele()
        {
            Console.WriteLine("Miau!");
        }

        public void LisaaPentu()
        {
             kissa kissa new Kissa
        }
        public List<Kissa> Pennut()
        {
            return pennut;
        }
        
    }
}
