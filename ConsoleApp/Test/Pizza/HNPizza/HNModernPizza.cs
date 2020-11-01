using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HNModernPizza : Pizza
    {
        public HNModernPizza()
        {
            name = "HN ModernPizza";
            toppings = "White olives";
            type.Add("Fat");
            type.Add("Short");
        }
        public override void AddingTypePizza()
        {
            base.AddingTypePizza();
            Console.WriteLine("ModernPizza is the best");

        }
    }
}
