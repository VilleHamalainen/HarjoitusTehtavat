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
    enum operatorNum
    {
        Addition = 1,
        Subtraction,
        Multiplication,
        Division,
        Random
    }
    public partial class Form1 : Form
    {
        bool Negative = false, fraction = false, divFraction = false;
        string msgSettings = "Please set all values in settings";

        

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

            //Launch options

            

        }
        
    }
}
