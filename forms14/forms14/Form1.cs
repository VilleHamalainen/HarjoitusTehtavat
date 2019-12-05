using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms14
{
    public partial class Form1 : Form
    {
        Point piste = new Point(0, 0);
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image = new Bitmap(Properties.Resources.hessu);
            image.MakeTransparent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics graf = e.Graphics;
            graf.DrawImage(image, piste);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            piste = e.Location;
            Invalidate();
        }
        
        
    }
}
