using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza
{
    class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "traditionalpizza":
                    return new HCMTraditionalPizza();
                    
                case "modernpizza":
                    return new HCMModernPizza();
                    
                case "greekpizza":
                    return new HCMGreekPizza();
                    
                default:
                    Console.WriteLine("We don't have this pizza");
                    return null;
            }
        }
    }
}
