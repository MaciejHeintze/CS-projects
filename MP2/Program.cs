using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asocjacja kwalifikowana Diet - DietType 
            //Kompozycja MainHall - Estate 

            //Asocjacja z atrybutem Event - Diet 
            //Asocjacja binarna Event - MainHall licznoœci 1 i 0...1

            //klasa Estate- opisuje obiekt jako nieruchomoœæ 
            //klasa MainHall - opsuje salê eventow¹ 

            Event ev1, ev2, ev3, ev4;
            Diet d1, d2, d3;
            Estate e1, e2, e3 = null;
            DietType dt1, dt2;
            MainHall mh1, mh2, mh3;
           
           
            e1 = new Estate("Pa³ac nad rzek¹");
            e2 = new Estate("Hotel L3");

            try
            {
                mh1 = new MainHall(e1); // licznoœc 0...1 asocjacja binarna 
                mh2 = new MainHall(e2);
                mh3 = new MainHall(e2);
                try
                {
                    mh3 = new MainHall(e3); // kompozycja 

                } catch (Exception ex)
                {
                    Console.WriteLine("B³¹d: kopozycja");
                }

                Console.WriteLine("Ekstesja MainHall przed usuniêciem obiektu Estate");
                foreach (MainHall hall in MainHall.getHall())
                {
                    Console.WriteLine(hall.ToString());
                }

                //usuwanie obiektu Estate 
                if (Estate.removeEstate(e2))
               {
                   Console.WriteLine("Obiekt Estete e2 usuniêty (Hotel L3)");
               }
                Console.WriteLine("Obiekt po usuniêciu: ");
                //MainHall po usuniêciu 
                foreach (MainHall hall in MainHall.getHall())
                {
                    Console.WriteLine(hall.ToString());
                }
                Console.WriteLine();
                
                e3 = new Estate("Zagroda Os");
                ev1 = new Event("Wesele Maciek i Estera", mh1);
                ev2 = new Event("Konferencja Google", mh2);
                mh1 = new MainHall(e3, ev2);
                mh2 = new MainHall(e3);
                ev3 = new Event("Komunia Kacpra", mh2);
                try
                {
                    ev4 = new Event("Wigilia firmy POLBAN", mh3); //asocjacja binarna o licznoœci 1
                }catch(Exception ex)
                {
                    Console.WriteLine("B³¹d: asocjacja binarna");
                }


                //asocjacja kwalifikowana 
                Console.WriteLine("asocjacja kwalifikowana: ");
                dt1 = new DietType(1, "Bezglutenowa");
                dt2 = new DietType(2, "Wegañska");
                d1 = new Diet("Kuchnia w³oska", dt1);
                d2 = new Diet("Kuchnia tajska", dt2);
                d3 = new Diet("Kuchnia polska");
                dt2.addDietType(d2);
                d2.changeDiet(dt1);
                Console.WriteLine(dt1.checkDiet(d2.getId()).ToString());




            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
