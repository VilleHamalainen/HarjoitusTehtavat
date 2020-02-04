using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Windows;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace checkScreenColor
{
    
    public partial class Form1 : Form
    {


        class Program
        {
            static void Main(string[] args)
            {
                int refreshes = 0;
                Color color = new Color();
                color = Color.FromArgb(108, 130, 132);  ////  93, 115, 119

                while (Thread.CurrentThread.IsAlive)
                {

                    using (Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                                Screen.PrimaryScreen.Bounds.Height))
                    using (Graphics g = Graphics.FromImage(bmpScreenCapture))
                    {
                        Point point = new Point(Cursor.Position.X, Cursor.Position.Y);

                        Point upPoint = new Point(point.X - 10, point.Y - 10);
                        Point dwPoint = new Point(point.X + 10, point.Y + 10);

                        g.CopyFromScreen(dwPoint,upPoint,
                                         bmpScreenCapture.Size);

                        if (bmpScreenCapture.GetPixel(point.X, point.Y) == color)
                        {
                            //Do Something
                            
                            //SendKeys.SendWait(" ");
                            //Thread.Sleep(1500);
                        }

                    }

                    refreshes++;
                    Console.WriteLine(refreshes);

                }


            }


        }
    }
}

    

