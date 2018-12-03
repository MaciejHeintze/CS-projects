using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{   
    class Diet
    {
        private string dietName;
        private int dietId;

        private static List<Diet> dietList = new List<Diet>();//ekstensja
        
        private static int counter = 0;
        private DietType type; //asocjacja kwalifikowana o liczności 1 

        public Diet(string dietName)
        {
            
            setDietName(dietName);
            setId(counter);
            counter++;
            this.type = null;
            dietList.Add(this);
            
        }

        public Diet(string dietName, DietType type)
        {
            
            setId(counter);
            setDietName(dietName);
            counter++;
            this.type = type;
            dietList.Add(this);
        }

        //atrybuty 
        public int getId()
        {
            return this.dietId;
        }

        private void setId(int dietId)
        {
            this.dietId = dietId;
        }

        public string getDietName()
        {
            return this.dietName;
        }

        public void setDietName(string dietName)
        {
            this.dietName = dietName;
        }

        //ekstensja 

        public static List<Diet> getDiets()
        {
            return dietList;
        }

        public static void removeDiets(Diet diet)
        {
            dietList.Remove(diet);
        }

        //asocjacja kwalifikowana 
        public DietType getDietType()
        {
            return this.type;
        }

        public void changeDiet(DietType type)
        {
            if(this.type == null)
            {
                type.addDietType(this);
                this.type = type;
            }else if(type == null)
            {
                this.type.removeDietType(this);
                this.type = null;
            }else if(this.type != type)
            {
                this.type.removeDietType(this);
                type.addDietType(this);
                this.type = type;
            }
        }

        public string ToString()
        {
            return "Nazwa diety: " + this.getDietName();
        }

        

        // asocjacje z połączonych klas
        /*
        public ISet<DietType> getConnector()
        {
            return DietType.getConnector(this);
        }

        public ISet<Event> getEvents()
        {
            return DietType.getEvents(getConnector());
        }
        */

    }
}
