using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(int.Parse(textBox1.Text));
            label1.Text = returnString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();

            int firstBtn;
            //string secondBtn;


            //firstBtn = client.GetData(int.Parse(textBox2.Text));
            //secondBtn = client.GetData(int.Parse(textBox3.Text));

            
            //firstBtn = client.;
            //label2.Text = ;
            

            
        }
    }
}
