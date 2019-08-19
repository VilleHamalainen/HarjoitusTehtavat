using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

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
            int inputSwitch = 0; bool success = false;
            //Tässä luot luokasta olion
            Hevonen polle = new Hevonen();
            Kissa Lucifer = new Kissa(7, "Lucifer");
            Kissa Aune = new Kissa(5, "Aune");
            Kissa Zeus = new Kissa(3, "Zeus");
            Koira Max = new Koira();

            Console.WriteLine("1. Hevonen");
            Console.WriteLine("2. Kissa");
            Console.WriteLine("3. Koira");


            while (success == false)
                success = int.TryParse(Console.ReadLine(), out inputSwitch);

            switch (inputSwitch)
            {
                case 1:
                    {
                        //Tulosta olion nimi ja paino
                        Console.WriteLine(polle.Nimi);
                        Console.WriteLine(polle.Paino);
                        //Muuta olion nimeä ja painoa
                        polle.Nimi = "vanha polle";
                        polle.Paino = 250;
                        //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
                        Console.WriteLine(polle.Nimi);
                        Console.WriteLine(polle.Paino);

                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Kissan nimi: " + Lucifer.name);

                        Console.Write("Anna kissalle uusi nimi: ");
                        Lucifer.SetCatName(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("Kissan nimi: " + Lucifer.name);
                        Console.WriteLine("Kissan ikä: " + Lucifer.Age);
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Uuden kissan nimi: " + Aune.name);
                        Console.WriteLine("Aunen ikä: " + Aune.Age);
                        Console.ReadKey();
                        Console.Clear();

                        Console.Write("Anna kissalle uusi nimi: ");
                        Zeus.SetCatName(Console.ReadLine());
                        Console.WriteLine("Kissan nimi: " + Zeus.name);
                        Console.ReadKey();
                        Console.Clear();

                        Console.Write("Anna kissalle uusi nimi: ");
                        Zeus.SetCatName(Console.ReadLine());
                        Console.WriteLine("Kissan nimi: " + Zeus.name);

                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {

                        break;
                    }
            }

            
            
            



        }
    }
}
