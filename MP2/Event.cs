using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    
    class Event
    {
        private static int counter = 0;
        private int EventId;
        private string eventName;
        private MainHall hall; // asocjacja binarna - liczność 1 
        private static List<Event> eventList = new List<Event>();// ekstensja 

        //<exception cref="Exception"></exception>
        public Event(string eventName, MainHall hall)
        {
            if(hall == null || !MainHall.getHall().Contains(hall))
            {
                throw new Exception("Main Hall can't be null");
            }
            counter++;
            setName(eventName);
            setId(counter);
            setHall(hall);
            eventList.Add(this);
            
        }

        public int getId()
        {
            return this.EventId;
        }

        private void setId(int EventId)
        {
            this.EventId = EventId;
        }

        public String getName()
        {
            return this.eventName;
        }

       public void setName(String eventName)
        {
            this.eventName = eventName;
        }

        public MainHall getHall()
        {
            return this.hall;
        }

        public int getHallId()
        {
            return this.hall.getHallId();
        }

        public void setHall(MainHall hall)
        {
            this.hall = hall;
            if(hall.getEvent() != this)
            {
                hall.setEvent(this);
            }
        }

        //ekstesnja 

        public static List<Event> getEvents()
        {
            return eventList;
        }

        public static void removeEvents(Event event1)
        {
            eventList.Remove(event1);
            foreach(EventDiet ev in event1.getConnector())
            {
                EventDiet.removeConnector(ev);
            }
           
        }


        //asocjacja z atrybutem 
        public ISet<EventDiet> getConnector()
        {
            return EventDiet.getConnector(this);
        }

        public ISet<Diet> getDiets()
        {
            return EventDiet.getDiets(getConnector());
        }


        public string ToString()
        {
            return "Nazwa eventu: " + this.getName() + Environment.NewLine + "ID sali: " + this.getHallId();
        }




    }
}

