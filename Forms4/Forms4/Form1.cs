using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button PainettuNappi = sender as Button;
            switch (PainettuNappi.Name)
            {
                case "button1":
                    MessageBox.Show("Valinta 1");
                    break;
                case "button2":
                    MessageBox.Show("Valinta 2");
                    break;
                case "button3":
                    MessageBox.Show("Valinta 3");
                    break;
                case "button4":
                    MessageBox.Show("Valinta 4");
                    break;
                case "button5":
                    MessageBox.Show("Default");
                    break;




            }
                
        }
    }
}
