using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int age;
        private string name;
        private bool onLihanSyoja;

        public Elain()
        {
            name = "Eläin";
            age = 0;
            onLihanSyoja = false;


        }
        public Elain(string name, int age, bool onLihanSyoja)
        {
                
        }




        //Asettaa eläimen iän
        public void SetAge(int uusiIka) 
        {
            if (uusiIka >= 0)
            {
                this.age = uusiIka;
            }
        }

        //Asettaa eläimelle nimen
        public void SetName(string name) 
        {
            this.name = name;
        }

        //Asettaa lihansyöjä
        public void SetCarnivore(bool onLihanSyoja)
        {
            this.onLihanSyoja = onLihanSyoja;
            
        }

        //palauttaa eläimen iän
        public int ReturnAge() 
        {
            return age;
        }

        //palauttaa eläimen nimen
        public string ReturnName() 
        {
            return name;
        }

        //Palauttaa on lihansyöjä
        public bool ReturnCarnivore()
        {
            return onLihanSyoja;
        }

        public virtual void Aantele()
        {
            Console.WriteLine("Umph!");
        }
    }
}
