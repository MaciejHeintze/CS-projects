using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBuilder
{
    class Program
    {
        private static void BuildCoffe(Barista barista)
        {
            barista.MakeCoffee();
            System.Console.WriteLine(barista.Coffee);
        }


        static void Main(string[] args)
        {
            Barista barista = new CoffeBuilder.Barista();
            barista.CoffeeBuilder = new CoffeeLatte();
            BuildCoffe(barista);
            barista.CoffeeBuilder = new Americano();
            BuildCoffe(barista);
            Console.ReadLine();
        }
    }
}
