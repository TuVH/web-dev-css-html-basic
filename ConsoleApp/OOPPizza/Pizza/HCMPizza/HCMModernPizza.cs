using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HCMModernPizza : Pizza
    {
        public HCMModernPizza()
        {
            name = "HCMModernPizza";
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
