using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Forms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread2;

            thread2 = new Thread(new ThreadStart(KirjoitaNumerot));
            thread2.Start();
        }

        private void KirjoitaNumerot()
        {

            if (!int.TryParse(textBox1.Text, out int result))
            {
                MessageBox.Show("Numerokentässä ei ole numeroita!");
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Aseta numero!");
            }
            else
            {
                for (int i = 0; i <= int.Parse(textBox1.Text); i++)
                {
                    string uusiNumero = i.ToString();
                    this.AsetaTeksti(uusiNumero);
                    Invalidate();
                    Thread.Sleep(10);
                }
            }
        }
        delegate void StringArgReturningVoidDelegate(string texti);

        private void AsetaTeksti(string texti)

        {

            // InvokeRequired required compares the thread ID of the   
            // calling thread to the thread ID of the creating thread.   
            // If these threads are different, it returns true.   

            if (this.label1.InvokeRequired)

            {   //Herätetään alkuperäinen säie 
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AsetaTeksti);
                this.Invoke(d, new object[] { texti });
            }

            else

            {   //Jos on alkupeäinen säie laitetaan se ´muuttamaan teksti 

                this.label1.Text = texti;
            }
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
