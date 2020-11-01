using System;
using System.Collections.Generic;

namespace Test
{
     abstract class Pizza
     {
        protected string name;
        protected string toppings;
        protected List<string> type = new List<string>();

        public Pizza()
        {
        }

        public void PreparePizza()
        {
            Console.WriteLine("Prepare pizza"+name);
        }
        public void AddingToppingsPizza()
        {
            Console.WriteLine("Adding Toppings" + toppings);
        }
        public virtual void AddingTypePizza()
        {
            type.ForEach((types) => Console.WriteLine("Adding"+types));
        }

    }


}

