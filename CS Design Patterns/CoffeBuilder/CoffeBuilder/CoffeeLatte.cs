using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBuilder
{
    class CoffeeLatte : CoffeeBuilder
    {
        public override void BuildCoffeeName()
        {
            coffee.Name = "Latte";
        }
        public override void BuildMilk()
        {
            coffee.MilkType = "No lactose";
        }
        public override void BuildSugar()
        {
            coffee.SugarType = "Brown";
        }
    }
}
