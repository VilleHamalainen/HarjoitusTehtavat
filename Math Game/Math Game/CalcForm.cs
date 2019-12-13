using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class CalcForm : Form
    {
        
        private Form1 form1;
        //Settings 
        bool negative = false, fract = false, divFract = false;
        //Min & Max numbers 
        int minNum = 0, maxNum = 0;
        int opNumber = 0;

        int num1 = 0, num2 = 0, randNum = 0;
        float answer = 0;
        Random rnd = new Random();


        public bool Negative { get => negative; set => negative = value; }
        public bool Fract { get => fract; set => fract = value; }
        public bool DivFract { get => divFract; set => divFract = value; }
        public int MinNum { get => minNum; set => minNum = value; }
        public int MaxNum { get => maxNum; set => maxNum = value; }
        public int OpNumber { get => opNumber; set => opNumber = value; }

        public CalcForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            label1.Text = negative.ToString() + fract + divFract + minNum + maxNum.ToString();
            
            num1 = rnd.Next(minNum, maxNum);
            num2 = rnd.Next(minNum, maxNum);

            if (Negative == false)
            {
                while (num2 > num1)
                {
                    num1 = rnd.Next(minNum, maxNum);
                    num2 = rnd.Next(minNum, maxNum);
                }
            }
            switch (OpNumber)
            {
                case 1:
                    {
                        label1.Text = $"{num1} + {num2} = ";
                        answer = num1 + num2;
                        break;
                    }
                case 2:
                    {
                        label1.Text = $"{num1} - {num2} =";
                        answer = num1 - num2;
                        break;
                    }
                case 3:
                    {
                        label1.Text = $"{num1} * {num2} = ";
                        answer = num1 * num2;
                        break;
                    }
                case 4:
                    {
                        label1.Text = $"{num1} / {num2} = ";
                        answer = num1 / num2;
                        break;
                    }
                case 5:
                    {
                        randNum = rnd.Next(1, 4);
                        if (randNum == 1)
                        {
                            label1.Text = $"{num1} + {num2} = ";
                            answer = num1 + num2;
                        }
                        else if (randNum == 2)
                        {
                            label1.Text = $"{num1} - {num2} = ";
                            answer = num1 - num2;
                        }
                        else if (randNum == 3)
                        {
                            label1.Text = $"{num1} * {num2} = ";
                            answer = num1 * num2;
                        }
                        else if (randNum == 4)
                        {
                            label1.Text = $"{num1} / {num2} = ";
                            answer = num1 / num2;
                        }
                        break;
                    }
            }

        }
        
        
        /*public static float Calculation(int OpNumber, bool Negative, int minNum, int maxNum, Label label1)
        {
            
        }*/

    }
}
