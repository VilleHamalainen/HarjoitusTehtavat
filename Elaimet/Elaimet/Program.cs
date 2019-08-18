using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luot luokasta olion
            Hevonen polle = new Hevonen();
            Kissa Lucifer = new Kissa();

            //Tulosta olion nimi ja paino
            Console.WriteLine(polle.Nimi);
            Console.WriteLine(polle.Paino);
            //Muuta olion nimeä ja painoa
            polle.Nimi = "testi";
            polle.Paino = 250;
            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Console.WriteLine(polle.Nimi);
            Console.WriteLine(polle.Paino);

            Console.ReadKey();

           

            Lucifer.cat_name = "Lucifer";
            Console.WriteLine(Lucifer.cat_name);
            Console.WriteLine(cat_age);
        }
    }
}
