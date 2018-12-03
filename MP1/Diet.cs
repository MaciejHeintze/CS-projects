using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{   [Serializable]
    class Diet
    {
        private static List<Diet> dietList; // ekstensja klasy
        public string dietName { get; set; }
        public string dietAdditionalInfo { get; set; }
        public double dietExtraCost { get; set; }
        

        //konstruktory - przeciążanie metod
        public Diet(string dietName, string dietAdditionalInfo, double dietExtraCost)
        {
            this.dietName = dietName;
            this.dietAdditionalInfo = dietAdditionalInfo;
            this.dietExtraCost = dietExtraCost;
            addDiet(this);
           
        }


        public Diet(string dietName)
        {
            this.dietName = dietName;
            this.dietAdditionalInfo = dietAdditionalInfo;
            this.dietExtraCost = dietExtraCost;
            addDiet(this);
        }

        public Diet(string dietName, string dietAdditionalIfno)
        {
            this.dietName = dietName;
            this.dietAdditionalInfo = dietAdditionalInfo;
            this.dietExtraCost = dietExtraCost;
            addDiet(this);
        }

        //obsługa ekstensji 
        private static void addDiet(Diet diet)
        {
            if(dietList == null)
            {
                dietList = new List<Diet>();
            }
        }
        public static void removeDiet(Diet diet)
        {
            if(dietList != null)
            {
                dietList.Remove(diet);
            }
        }

        public static void showEvents()
        {
            foreach(Diet d in dietList)
            {
                Console.WriteLine(d.ToString());
            }
        }
        //przesłoniecie metody toString()
        public override string ToString()
        {
            return "Dieta: "+dietName+Environment.NewLine+"Dodatkowe informacje: "+dietAdditionalInfo+Environment.NewLine+"Dodatkowy koszt za osobe: "+dietExtraCost;
        }



    }
}
