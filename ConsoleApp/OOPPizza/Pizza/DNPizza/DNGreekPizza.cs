using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DNGreekPizza : Pizza
    {
        public DNGreekPizza()
        {
            name = "DN GreekPizza";
            toppings = "DN sauces good";
            type.Add("DN small");
            type.Add("DN Tall");
        }
        public override void AddingTypePizza()
        {
            base.AddingTypePizza();
            Console.WriteLine("GreekPizza is the best");
        }
    }
}
