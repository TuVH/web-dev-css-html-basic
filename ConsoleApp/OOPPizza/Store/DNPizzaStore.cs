using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza
{
    class DNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "traditionalpizza":
                    return new DNTraditionalPizza();

                case "modernpizza":
                    return new DNModernPizza();

                case "greekpizza":
                    return new DNGreekPizza();

                default:
                    Console.WriteLine("We don't have this pizza");
                    return null;
            }
        }
    }
}
