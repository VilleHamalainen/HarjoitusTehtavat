using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;
using System.Security;

namespace GnomeDistributing
{
    class Program
    {

        static List<string> GetDir(string dir)
        {


            List<string> DirItem = new List<string>();
            foreach (string d in Directory.GetDirectories(dir))
            {
                DirItem.Add(d);
            }
            return DirItem;
            }
        static void Main(string[] args)
        {

            var path = new Uri(
              System.IO.Path.GetDirectoryName(
                  System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
              ).LocalPath;

            Random rnd = new Random();
            List<string> DirItem = new List<string>();
            string dir = @"C:\";
            DirItem = GetDir(dir);
            Directory.SetCurrentDirectory(dir);

            while (true)
            {
                loop:
                int RandomFolder = rnd.Next(0, DirItem.Count);
                if(DirItem.Count == 0)
                {
                    break;
                }
                dir = DirItem[RandomFolder];
                try
                {
                    Directory.SetCurrentDirectory(dir);
                }
                catch
                {
                    goto loop;
                }
                
                DirItem.Clear();
                DirItem = GetDir(dir);
                for (int j = 0; j < DirItem.Count; j++)
                {
                    Console.WriteLine(DirItem[j]);
                }
                
                Console.ReadKey();
            }

            string currentDir = Directory.GetCurrentDirectory();
            File.Copy(path + @"\gnomed.png", currentDir + @"\");

                
            }
            
        }
    }

