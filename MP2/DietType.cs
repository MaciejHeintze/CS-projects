using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    class DietType
    {
        private int dietId;
        private string dietName;
        private static List<DietType> dietList = new List<DietType>(); //ekstensja
        private Dictionary<int, Diet> diets;//asocjacja kwalifikowana o liczności *


        public DietType(int id,string name)
        {
            setName(name);
            setId(id);
            this.diets = new Dictionary<int, Diet>();
            dietList.Add(this);
        }



        public int getId()
        {
            return this.dietId;
        }

        private void setId(int dietId)
        {
            this.dietId = dietId;
        }

        public string getName()
        {
            return this.dietName;
        }

        public void setName(String dietName)
        {
            this.dietName = dietName;
        }

        //ekstensja 

        public static List<DietType> getDiets()
        {
            return dietList;
        }

        public static bool removeDiets(DietType diet)
        {
            return dietList.Remove(diet);
        }

        //asocjacja kwalifikowana 

        public Dictionary<int, Diet> GetDietType()
        {
            return this.diets;
        }

        public void addDietType(Diet diet)
        {
            if (!this.diets.ContainsKey(diet.getId())) 
            {
                this.diets.Add(diet.getId(), diet);
                diet.changeDiet(this); 
            }
        }

        public void removeDietType(Diet diet)
        {
            if (this.diets.ContainsKey(diet.getId()))
            {
                this.diets.Remove(diet.getId());

                if (diet.getDietType() == this)
                {
                    diet.changeDiet(null);
                }
                
            }
        }
        
        //<exception cref="Exception"></exception>
        public Diet checkDiet(int id)
        {
            if (this.diets.ContainsKey(id))
            {
               
                return diets[id]; 
            }
            else
            {
                throw new Exception("Nie ma takiej diety");
            }
        }

         










    }
}
