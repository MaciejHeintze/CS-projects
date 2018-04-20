using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBuilder
{
    class Americano : CoffeeBuilder
    {
        public override void BuildCoffeeName()
        {
            coffee.Name = "Americano";
        }
        public override void BuildMilk()
        {
            coffee.MilkType = "No ";
        }
        public override void BuildSugar()
        {
            coffee.SugarType = "White ";
        }
    }
}
