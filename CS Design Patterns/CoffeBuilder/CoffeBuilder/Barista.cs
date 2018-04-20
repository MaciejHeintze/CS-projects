using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBuilder
{
    class Barista
    {
        private CoffeeBuilder coffeeBuilder;

        public CoffeeBuilder CoffeeBuilder
        {
            get { return coffeeBuilder; }
            set { coffeeBuilder = value; }
        }
        public Coffee Coffee { get { return coffeeBuilder.Coffee; } }

        public void MakeCoffee()
        {
            coffeeBuilder.CreateCoffee();
            coffeeBuilder.BuildCoffeeName();
            coffeeBuilder.BuildMilk();
            coffeeBuilder.BuildSugar();
        }
    }
}
