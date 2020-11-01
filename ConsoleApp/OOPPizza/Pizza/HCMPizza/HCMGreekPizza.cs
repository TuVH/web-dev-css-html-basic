using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "HCMGreekPizza";
            toppings = "sauces good";
            type.Add("small");
            type.Add("Tall");
        }
        public override void AddingTypePizza()
        {
            base.AddingTypePizza();
            Console.WriteLine("GreekPizza is the best");
        }
    }
}
