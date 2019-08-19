using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    class Elain
    {
        private int age;
        public string name;
        private bool onLihanSyoja;

        //Asettaa eläimen iän
        public void SetAnimalAge(int uusiIka) 
        {
            if (uusiIka >= 0)
            {
                this.age = uusiIka;
            }
        }

        //Asettaa eläimelle nimen
        public void SetAnimalName(string name) 
        {
            this.name = name;
        }

        //Asettaa lihansyöjä
        public void SetCarnivore(bool onLihanSyoja)
        {

        }

        //palauttaa eläimen iän
        public int ReturnAnimalAge() 
        {
            return age;
        }

        //palauttaa eläimen nimen
        public string ReturnAnimalName() 
        {
            return name;
        }

        //Palauttaa on lihansyöjä
        public bool ReturnCarnivore()
        {
            return onLihanSyoja;
        }
    }
}
