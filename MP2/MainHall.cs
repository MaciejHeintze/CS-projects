using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    class MainHall
    {
        private int hallId;
        private Estate estate = null; // kompozycja liczność 1
        private static int counter = 0;
        private static List<MainHall> halls = new List<MainHall>(); // ekstensja
        private Event event1 = null; // asocjacja binarna licznosc 0...1



        public MainHall(Estate estate)
        {
            if (estate == null || !Estate.getEstates().Contains(estate))
            {
                throw new Exception("Estate can't be null");
            }
                counter++;
                setEvent(null);
                setHallId(counter);
                setEstate(estate);
                halls.Add(this);   
        }

        public MainHall(Estate estate, Event event1)
        {
            if(estate == null || !Estate.getEstates().Contains(estate))
            {
                throw new Exception("Estate can't be null");
            }

            counter++;
            setHallId(counter);

            if(event1.getHall() != null)
            {
                event1.getHall().setEvent(null); // oznaczenie jako puste 
                setEvent(event1);
                setEstate(estate);
                halls.Add(this);
            }




        }

        //atrybuty 

        public int getHallId()
        {
            return this.hallId;
        }

        private void setHallId(int hallId)
        {
            this.hallId = hallId;
        }

        public Event getEvent()
        {
            return this.event1;
        }

        public void setEvent(Event event1)
        {
            if (event1 == null)
                return;
            this.event1 = event1;
            if(event1.getHall() != this)
            {
                event1.setHall(this);
            }
        }

        public static List<MainHall> getHall()
        {
            return halls;
        }

        public static bool removeHall(MainHall hall)
        {
            if(hall == null || !halls.Contains(hall))
            {
                return false;
            }

            if(hall.getEvent() != null)
            {
                throw new Exception("Nie można usunąć sali zajętej przez " + hall.getEvent().ToString());
            }

            if (hall.getEstate().containsMainHall(hall))
            {
                halls.Remove(hall);
                hall.getEstate().removeMainHall(hall);
                return true;
            }
            return false;
        }

        //asocjacja 

        public Estate getEstate()
        {
            return this.estate;
        }


        private void setEstate(Estate estate)
        {
            this.estate = estate;
            estate.AddMainHall(this);
        }

        public string ToString()
        {
            return "Sala o id: " + getHallId() + " z obiektu: " + getEstate().getName();
        }


    }
}
