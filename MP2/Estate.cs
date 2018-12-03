using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    class Estate
    {
        private string estateName;
        private static List<Estate> estates = new List<Estate>(); // ekstensja 
        private List<MainHall> hall; // kompozycja liczność - *
        

        //konstruktor
        public Estate(String estateName)
        {
            setName(estateName);
            this.hall = new List<MainHall>();
            estates.Add(this);
        }

        //atrybuty

        public string getName()
        {
            return this.estateName;
        }

        private void setName(string estateName)
        {
            this.estateName = estateName;
        }
        //obsługa ekstensji
        public static List<Estate> getEstates()
        {
            return estates;
        }
        //obsługa kompozycji 

        public List<MainHall> getMainHall()
        {
            return this.hall;
        }
        public void AddMainHall(MainHall mainHall)
        {
            if (!hall.Contains(mainHall))
            {
                this.hall.Add(mainHall);
            }
        }

        public bool containsMainHall(MainHall mainHall)
        {
            return this.hall.Contains(mainHall);
        }

        public bool removeMainHall(MainHall mainHall)
        {
            if(mainHall != null && containsMainHall(mainHall))
            {
                MainHall.removeHall(mainHall);
                this.hall.Remove(mainHall);
                return true;
            }
            return false;
        }

        //<exception cref="Exception"></exception>
        public static bool removeEstate(Estate estate)
        {
            if (!estates.Contains(estate))
            {
                return false;
            }
            List<MainHall> additionalHall = new List<MainHall>();
            foreach(MainHall hall1 in estate.getMainHall())
            {
                additionalHall.Add(hall1);
            }
            foreach(MainHall hall1 in additionalHall)
            {
                estate.removeMainHall(hall1);
            }
            return estates.Remove(estate);
        }

        public string ToString()
        {
            return "Obiekt o nazwie: " + getName();
        }


    }
}
