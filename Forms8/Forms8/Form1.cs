using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms8
{
    public partial class Form1 : Form
    {
        int rand_Num = 0; int oikein = 0; int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Random rnd = new Random();
            int[] labels = {1,2,3,4,5,6,7,8,9,10/*,11,
            12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,
            27,28,29,30,31,32,33,34,35,36,37,38,39,40*/};
            int[] lottoNum = new int[7];
            int[] userInput = new int[7];

            //Asettaa käyttäjän numerot userInput Arrayyn.
            foreach(NumericUpDown input in groupBox2.Controls.OfType<NumericUpDown>())
            {
                userInput.SetValue((Convert.ToInt32(input.Value)), i);
                i++;
            }

            //Printtaa Käyttäjän numerot
            foreach (var values in userInput)
            {
                label2.Text += values + ", ";
            }
            
            for (int i = 0; i < 7; i++)
            {
                rand_Num = rnd.Next(0, 9);
                while(labels[rand_Num] == 0)
                {
                    rand_Num = rnd.Next(0, 9);
                }
                lottoNum.SetValue(labels[rand_Num], i);
                labels[rand_Num] = 0;
            }

            foreach(var values in lottoNum)
            {
                label1.Text += values + ", ";
            }
            foreach ()
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
