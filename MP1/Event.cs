using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    [Serializable]
    class Event
    {

        private Diet specialDiet; //atrybut złożony i opcjonalny
        private List<double> previousEventsPrice = new List<double>(); // atrybut powtarzalny - ceny poprzednich eventów
        private static string eventName; // atrybut klasowy 
        private double eventGrossPrice; // atrybut pochodny - od ceny netto 
        private double eventNetPrice; // atrybut prosty - cena netto 
        private static double tax = 1.23;

        public Event()
        {
            addEvent(this); //dodawanie do ekstensji  
        }

        //ekstensja
        private static List<Event> eventsList = new List<Event>();
        //obsługa ekstensji
        private static void addEvent(Event e)
        {
            if(eventsList == null)
            {
                eventsList = new List<Event>();
            }
            eventsList.Add(e);
        }

        private static void cancelEvent(Event e)
        {
            if(eventsList != null)
            {
                eventsList.Remove(e);
            }
         
        }

        public static void showEvents(String x)
        {
            if(x == null)
            {
                foreach(Event e in eventsList)
                {
                    Console.WriteLine(e.ToString());
                }

            }else if(x == eventName)
            {
                foreach (Event e in eventsList)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
      
    
        public Diet getSpecialDiet()
        {
            return this.specialDiet;
        }

        public void setSpecialDiet(Diet diet)
        {
            this.specialDiet = diet;
        }

        public List<double> getPreviousEventsPrice()
        {
            return this.previousEventsPrice;
        }

        public void addPreviousEventsPrice(double price)
        {
            this.previousEventsPrice.Add(price);
        }

        public void removePreviousEventsPrice(double price)
        {
            this.previousEventsPrice.Remove(price);
        }

        //atrybut klasowy - getter
        public static string getEventName()
        {
            return eventName;
        }
        //atrybut klasowy - setter
        public static void setEventName(string eName)
        {
            eventName = eName;
        }

        public double getEventNetPrice()
        {
            return eventNetPrice;
        }

        public void setEventNetPrice(double eventNetPrice)
        {
            this.eventNetPrice = eventNetPrice;
            this.eventGrossPrice = eventNetPrice * tax;
        }
        public double getEventGrossPrice()
        {
            return this.eventGrossPrice;
        }
        //przesłonięcie metod toString()
        public override string ToString()
        {
            return "Nazwa eventu: " + getEventName() + Environment.NewLine + "Cena brutto: " + getEventGrossPrice();
        }

        




        }
    }

