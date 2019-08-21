using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Koira: Nisakkaat //class name
    {
        

        public Koira()
        {

        }
        public override void Aantele()
        {
            Console.WriteLine("Hau!");
        }
        //constructors
        /*
        //fields
        private int age;
        public string name;

        public int Age { get => age; set => age = value; }
        public Koira(int age, string name) //constructor with parameters
        {
            this.name = name;
            this.age = age;
        }

        public bool SetName(string name) //method
        {
            
            if(name.ToLower() == "musti")
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
