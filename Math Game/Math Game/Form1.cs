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
    enum OperatorNum
    {
        Addition = 1,
        Subtraction,
        Multiplication,
        Division,
        Random
    }
    public partial class Form1 : Form
    {
        bool Negative = false, parsedMin = false, parsedMax = false; 
        string msgSettings = "Please set all values in settings";
        int opNum = 0;

        

        public Form1()
        {
            InitializeComponent();
            
        }

        int correct = 0, wrong = 0;

        int minNum = 0, maxNum = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            correct_label.Text = $"Oikein: {correct}";
            wrong_label.Text = $"Väärin: {wrong}";
        }

        public int Correct { get => correct; set => correct = value; }
        public int Wrong { get => wrong; set => wrong = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            //Settings

            if (yesNegative.Checked)
                { Negative = true; }
            else if(noNegative.Checked)
                { Negative = false; }
            else { MessageBox.Show(msgSettings); }

            parsedMin = int.TryParse(txtMin.Text, out minNum);
            if (parsedMin == false)
            {
                MessageBox.Show("Input a valid min number.");
            }
            txtMin.Clear();
            
            parsedMax = int.TryParse(txtMax.Text, out maxNum);
            if(parsedMax == false)
            {
                MessageBox.Show("Input a valid max number.");
            }
            txtMax.Clear();



            //Launch options

            if (parsedMin == true && parsedMax == true)
            {
                if (radioAddition.Checked)
                {
                    opNum = (int)OperatorNum.Addition;
                }

                else if (radioSubtraction.Checked)
                {
                    opNum = (int)OperatorNum.Subtraction;
                }

                else if (radioMultiplication.Checked)
                {
                    opNum = (int)OperatorNum.Multiplication;
                }

                else if (radioDivision.Checked)
                {
                    opNum = (int)OperatorNum.Division;
                }

                else if (radioRandom.Checked)
                {
                    opNum = (int)OperatorNum.Random;
                }

                using (var CalcForm = new CalcForm(this))
                {
                    CalcForm.Negative = Negative;

                    CalcForm.MinNum = minNum;
                    CalcForm.MaxNum = maxNum;

                    CalcForm.OpNumber = opNum;

                    CalcForm.ShowDialog();
                    Form1_Load(sender, e);
                }
            }
            

            

            
            
            parsedMin = false;
            parsedMax = false;
        }
        
    }
}
