using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms9
{
    public partial class Form1 : Form
    {
        List<string> Lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista = new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Lista.Add(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Luo ensin lista");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string asia in Lista)
            {
                comboBox1.Items.Add(asia);
            }
            
        }
    }
}
