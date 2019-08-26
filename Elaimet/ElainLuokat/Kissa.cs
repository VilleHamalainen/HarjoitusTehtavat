using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa: Nisakkaat //class name
    {
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

        /*


        
        public int Age { get => age; set => age = value; }
        public Kissa(int age, string name) //constructor with parameters
        {
            this.name = name;
            this.age = age;
        }
        
        public bool SetName(string name) //method
        {
            
            if(name.ToLower() == "hilda")
            {
                Console.WriteLine("Nimenvaihto epäonnistui");
                return false;   
            }
            this.name = name;
            Console.WriteLine("Nimenvaihto onnistui");
            return true;
        }

        public void SetAge(int age) //method
        {
            this.age = age;
        }


        public string ReturnName(string name)
        {
            return name;
        }

        public int ReturnAge()
        {
            return age;
        }*/
    }
}
