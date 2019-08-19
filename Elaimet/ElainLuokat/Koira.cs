using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Koira //class name
    {
        //fields
        private int age;
        public string name;

        public int Age { get => age; set => age = value; }

        public Koira() { } //constructors


        public Koira(int age, string name) //constructor with parameters
        {
            this.name = name;
            this.age = age;
        }

        public bool SetDogName(string name) //method
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

        public void SetDogAge(string age) //method
        {
            bool success = false;

            while(success == false)
            success = int.TryParse(Console.ReadLine(), out this.age);
            
        }


        public string ReturnDogName(string name)
        {
            return name;
        }

        public int ReturnDogAge(int age)
        {
            return age;
        }
    }
}
