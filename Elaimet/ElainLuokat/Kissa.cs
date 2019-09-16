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
        private Kissa emo;
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
            Console.WriteLine("Kuinka monta pentua?");
            int input = int.Parse(Console.ReadLine());
            for(int i = 1; i <= input; i++)
            {
                Kissa pentu = new Kissa();
                pentu.Emo = this;
                
                pennut.Add(pentu);  
            }
            
        }
        public List<Kissa> Pennut
        {
            get
            {
                return pennut;
            }
            
        }
        public Kissa Emo { get => emo; set => emo = value; }
    }
}
