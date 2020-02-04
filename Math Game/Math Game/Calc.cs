using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class Calc
    {
        Random rnd = new Random();
        private float num1 = 0;
        private float num2 = 0;
        private int opNum = 0;
        private float answer = 0;
        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }
        public int OpNum { get => opNum; set => opNum = value; }
        public float Answer { get => answer; set => answer = value; }

        public Calc(int num1, int opNum, int num2)
        {

        }

        
    }
}
