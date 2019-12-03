using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms10
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dict;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           dict = new Dictionary<string, string>();

        }

        private void LisaaDictionaryyn(object sender, EventArgs e)
        {
            dict.Add((textBox1.Text), textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dict.ContainsKey(textBox3.Text))
            {
                textBox4.Text = dict[textBox3.Text];
            }
                
            
               // textBox4.Text = dict[textBox3.Text]; .Keys.ElementAt(textBox3.Text)
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
