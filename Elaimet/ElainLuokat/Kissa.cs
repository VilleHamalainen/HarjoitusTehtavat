using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa //class name
    {
        //fields
        private int age;
        public string name;

        public int Age { get => age; set => age = value; }

        public Kissa() { } //constructors


        public Kissa(int age, string name) //constructor with parameters
        {
            this.name = name;
            this.age = age;
        }

        public bool SetCatName(string name) //method
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

        public void SetCatAge(string age) //method
        {
            bool success = false;

            while(success == false)
            success = int.TryParse(Console.ReadLine(), out this.age);
            
        }


        public string ReturnCatName(string name)
        {
            return name;
        }

        public int ReturnCatAge(int age)
        {
            return age;
        }
    }
}
