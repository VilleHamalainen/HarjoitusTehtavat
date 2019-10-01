using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms7
{
    public partial class Form1 : Form
    {
        int[] NumeroLista;
        int size = 0;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = true; 
            while(success)
            {
                
                if(!int.TryParse(textBox1.Text, out size)){
                    MessageBox.Show("Aseta numero");
                    textBox1.Clear();
                }
                else
                {
                    
                    break;
                }
               
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroLista = new int[size];
            
            while(true)
            {
                bool success = int.TryParse(textBox3.Text, out index);
                if (success){
                    NumeroLista[index] = int.Parse(textBox2.Text);
                    MessageBox.Show("Size: " + size + " Index: " + index);
                    break;
                }
                else { }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int search = int.Parse(textBox4.Text);
            label8.Text = NumeroLista[search].ToString();
            
        }
    }
}
