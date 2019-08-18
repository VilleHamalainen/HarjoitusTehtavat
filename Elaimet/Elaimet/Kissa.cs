using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Kissa //class name
    {
        //fields
        private int cat_age;
        public string cat_name;

        
        public Kissa() //constructors
        {
            
        }
        public Kissa(int cat_age, string cat_name) //constructor with parameters
        {
            this.cat_name = name;
            this.cat_age = cat_age;
        }
        public void SetCatAge(string cat_name) //method
        {
            this.cat_name = name;
        }
        public string ReturnCatName()
        {
            return cat_name;
        }
        public int ReturnCatAge()
        {
            return cat_age;
        }
    }
}
