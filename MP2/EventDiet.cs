using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    class EventDiet
    {
       
        private static ISet<EventDiet> set = new HashSet<EventDiet>(); //ekstensja
        private Event event1;//asocjacja o liczności 1
        private Diet diet;//asocjacja o liczności 1 

        private EventDiet(Event event1, Diet diet)
        {

        }
        
        //atrybuty 

        public Event getEvent()
        {
            return this.event1;
        }
        public int getEventId()
        {
            return this.event1.getId();
        }

        private void setEvent(Event event1)
        {
            this.event1 = event1;
        }

        public Diet getDiet()
        {
            return this.diet;
        }

        public int getDietId()
        {
            return this.diet.getId();
        }

        private void setDiet(Diet diet)
        {
            this.diet = diet;
        }

       //ekstensja 
       public static ISet<EventDiet> getConnector()
        {
            return set;
        }

        public static ISet<EventDiet> getConnector(Diet diet)
        {
            ISet<EventDiet> set1 = null;
            foreach(EventDiet sets in set)
            {
                if(sets.getDietId() == diet.getId())
                {
                    if(set1 == null)
                    {
                        set1 = new HashSet<EventDiet>();
                        set1.Add(sets);
                    }
                }
                
            }
            return set1;
        }

        public static ISet<EventDiet> getConnector(Event event1)
        {
            ISet<EventDiet> set1 = null;
            foreach(EventDiet sets in set)
            {
                if(sets.getEventId() == event1.getId())
                {
                    if(set1 == null)
                    {
                        set1 = new HashSet<EventDiet>();
                        set1.Add(sets);
                    }
                }
            }
            return set1;
        }

        public static ISet<EventDiet> getConnector(Event event1, Diet diet)
        {
            ISet<EventDiet> eventDiet = null;
            foreach(EventDiet set1 in set)
            {
                if(set1.getEventId() == event1.getId() && set1.getDietId() == diet.getId())
                {
                    if(eventDiet == null)
                    {
                        eventDiet = new HashSet<EventDiet>();
                        eventDiet.Add(set1);
                    }
                }
            }
            return eventDiet;
        }

        public static ISet<Event> getEvents(ICollection<EventDiet> set2)
        {
            ISet<Event> events1 = new HashSet<Event>();
            foreach(EventDiet set1 in set2)
            {
                events1.Add(set1.getEvent());
                
            }
            return events1;
        }

        public static ISet<Diet> getDiets(ICollection<EventDiet> set2)
        {
            ISet<Diet> diets1 = new HashSet<Diet>();
            foreach(EventDiet set1 in set2)
            {
                diets1.Add(set1.getDiet());
            }
            return diets1;
        }

        public static bool removeConnector(EventDiet eventDiet)
        {
            return set.Remove(eventDiet);
        }

        //przeciążona metoda
        public string ToString()
        {
            return "Event o nazwie: " + this.getEvent().getName() + " posiada nastepujace diety: " + this.getDiet().getDietName();
        }


      



    }
}
