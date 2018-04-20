using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBuilder
{
    abstract class CoffeeBuilder
    {
        protected Coffee coffee;
        public Coffee Coffee { get { return coffee; } }

        public void CreateCoffee()
        {
            coffee = new Coffee();
        }

        public abstract void BuildCoffeeName();
        public abstract void BuildMilk();
        public abstract void BuildSugar();


    }
}
