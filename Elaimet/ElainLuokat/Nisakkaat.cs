using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Nisakkaat: Elain
    {
        //attributes
        private int teeth;
        

      
        public Nisakkaat()
        {

        }

        public void SetTeeth(int teeth)
        {
            this.teeth = teeth;
        }

        public int ReturnTeeth()
        {
            return teeth;
        }
    }
}
