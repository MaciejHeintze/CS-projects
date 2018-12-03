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

            //impementacja ekstensji 
            Event e1 = new Event();
           

            //utworzenie przyk³adowych diet
            Diet glutenFreeDiet = new Diet("Gluten Free", "soy sos gluten free", 10);
            Diet lactoseFreeDiet = new Diet("Lactose Free", "-", 5);
            Diet test = new Diet("Dieta testowa");


            //atrybut klasowy 
            Event.setEventName("Wesele Estery i Macka");
            // Console.WriteLine("Event name: " + Event.getEventName());

            e1.setEventNetPrice(10000);

            Console.WriteLine("Ekstensje klasy Event: ");
            Event.showEvents(null);

            Console.WriteLine("Ekstensje klasy Diet: ");
            Diet.showEvents();

            //atrybut z³o¿ony 
            e1.setSpecialDiet(glutenFreeDiet);
            Console.WriteLine(e1.getSpecialDiet().ToString()); 

            //atrybut powtarzalny 
            e1.addPreviousEventsPrice(12000);
            e1.addPreviousEventsPrice(13000);
            e1.addPreviousEventsPrice(12000);
            e1.addPreviousEventsPrice(25000);

            Console.WriteLine("Previous events prices: ");
            foreach(double x in e1.getPreviousEventsPrice())
            {
                Console.WriteLine(x.ToString() + " PLN");
            }

            

            //atrybut prosty i od niego pochodny 
            
            e1.setEventNetPrice(13500); //atrybut prosty
            Console.WriteLine("Cena brutto (do zap³aty): "+ e1.getEventGrossPrice()); // atrybut pochodny
            

            

            //serializacja - trwa³oœæ ekstensji 
            string path = @"data.bin";
            BinarySerializer<Event>.Serialize(path, e1);

            Event e = null;
            e = BinarySerializer<Event>.Deserialize(path);
            Console.WriteLine("Serializacja udana");



            Console.ReadLine();
        }
    }
}
