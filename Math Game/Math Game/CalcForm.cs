using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Math_Game
{
    public partial class CalcForm : Form
    {
        public static int GetSeed()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var intBytes = new byte[4];
                rng.GetBytes(intBytes);
                return BitConverter.ToInt32(intBytes, 0);
            }
        }

        public void wait(int ms)
        {
            Thread.Sleep(ms);
        }

        private Form1 form1;
        //Settings 
        bool negative = false, parsed = false;
        //Min & Max numbers 
        int minNum = 0, maxNum = 0;
        int opNumber = 0; 

        int num1 = 0, num2 = 0, randNum = 0;
        int answer = 0, numInput = 0;

        int correct = 0; int wrong = 0;
        Random rnd = new Random(GetSeed());

        
        public bool Negative { get => negative; set => negative = value; }


        public int Correct { get => correct; set => correct = value; }
        public int Wrong { get => wrong; set => wrong = value; }

        public int MinNum { get => minNum; set => minNum = value; }

        

        public int MaxNum { get => maxNum; set => maxNum = value; }
        public int OpNumber { get => opNumber; set => opNumber = value; }

        public CalcForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            form1.Wrong = wrong;
            form1.Correct = correct;
            
            this.Close();


        }

        private void submit_btn_Click(object sender, EventArgs e)
              {

            
            parsed = int.TryParse(textBox1.Text, out numInput);
            if (parsed == false)
            {
                MessageBox.Show("Enter a valid value.");
            }
            
        
            parsed = false;
              
            if (numInput == answer)
            {
            label2.Visible = true;
            correct++;
            }
            else
            {
            label2.Visible = false;
            wrong++;
            }
                    
            CalcForm_Load(sender, e);
        }
        
        private void CalcForm_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            label3.Text = $"Oikein: {correct}\nVäärin: {wrong} \n\nMin number: {MinNum} \nMax number: {MaxNum}";
            if (answer != 0 || numInput != 0)
            {
                numInput = 0;
                answer = 0;
            }

            num1 = rnd.Next(minNum, maxNum);
            num2 = rnd.Next(minNum, maxNum);

            //Luo negatiivisia & positiivisia lukuja tai pelkkiä positiivisia
            if (Negative == false)
            {
                while (num2 > num1)
                {
                    num1 = rnd.Next(minNum, maxNum);
                    num2 = rnd.Next(MinNum, num1);
                    
                }
            }


            //Valitsee operaattorin
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
        
        

    }
}
