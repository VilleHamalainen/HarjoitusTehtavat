using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    class Calc
    {
        private float num1 = 0;
        private float num2 = 0;
        private int opNum = 0;
        private float answer = 0;
        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }
        public int OpNum { get => opNum; set => opNum = value; }
        public float Answer { get => answer; set => answer = value; }

        public float Calculation()
        {
            switch (OpNum)
            {
                case 1:
                    {
                        answer = num1 + num2;
                        break;
                    }
                case 2:
                    {
                        answer = num1 - num2;
                        break;
                    }
                case 3:
                    {
                        answer = num1 * num2;
                        break;
                    }
                case 4:
                    {
                        answer = num1 / num2;
                        break;
                    }
            }
            return answer;
        }
    }
}
