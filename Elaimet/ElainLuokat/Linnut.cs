using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Linnut: Elain
    {
        //attributes
        private int feathers;

        public Linnut()
        {

        }

        public void SetFeathers(int feathers)
        {
            this.feathers = feathers;
        }

        public int ReturnFeathers()
        {
            return feathers;
        }

    }
}
