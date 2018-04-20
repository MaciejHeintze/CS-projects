using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBuilder
{
    class Coffee
    {
        private string name;
        private string milkType;
        private string sugarType;

        public string Name { get { return name; } set { name = value; } }
        public string MilkType { get { return milkType; } set { milkType = value; } }
        public string SugarType { get { return sugarType; } set { sugarType = value; } }

        public override string ToString()
        {
            
                return string.Format(
                    "{0} coffe with {1} milk and {2} sugar ", name, milkType, sugarType);
            }
        }


    }

