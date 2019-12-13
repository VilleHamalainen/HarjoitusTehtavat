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
        bool Negative = false, fraction = false, divFraction = false, parsed = false; 
        string msgSettings = "Please set all values in settings";
        int opNum = 0;
        int minNum = 0, maxNum = 0;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Settings

            if (yesNegative.Checked)
                { Negative = true; }
            else if(noNegative.Checked)
                { Negative = false; }
            else { MessageBox.Show(msgSettings); }

            if (yesFraction.Checked)
            { fraction = true; }
            else if (noFraction.Checked)
            { fraction = false; }
            else { MessageBox.Show(msgSettings); }

            if (yesDivFraction.Checked)
            { divFraction = true; }
            else if (noDivFraction.Checked)
            { divFraction = false; }
            else { MessageBox.Show(msgSettings); }

            
            while (parsed == false)
            {
                parsed = int.TryParse(txtMin.Text, out minNum);
                if (parsed == false)
                {
                    MessageBox.Show("Input only numbers.");
                }
            }
            parsed = false;
            while (parsed == false)
            {
                parsed = int.TryParse(txtMax.Text, out maxNum);
                if(parsed == false)
                {
                    MessageBox.Show("Input only numbers.");
                }
            }



            //Launch options

            if (radioAddition.Checked)
            {
                opNum =  (int)OperatorNum.Addition;
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
                CalcForm.Fract = fraction;
                CalcForm.DivFract = divFraction;

                CalcForm.MinNum = minNum;
                CalcForm.MaxNum = maxNum;

                CalcForm.OpNumber = opNum;

                CalcForm.ShowDialog();
            }
        }
        
    }
}
