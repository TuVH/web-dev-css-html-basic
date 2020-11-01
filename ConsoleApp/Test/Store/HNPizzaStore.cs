using System;

namespace Test
{
    class HNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "traditionalpizza":
                    return new HNTraditionalPizza();
                    
                case "modernpizza":
                    return  new HNModernPizza();
                    
                case "greekpizza":
                    return new HNGreekPizza();
                    
                default:
                    Console.WriteLine("We don't have this pizza");
                    return null;
            }
        }
    }
}
