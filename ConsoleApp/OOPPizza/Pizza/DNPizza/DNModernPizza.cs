using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza
{
    class DNModernPizza : Pizza
    {
        public DNModernPizza()
        {
            name = "DN ModernPizza";
            toppings = "DN White olives";
            type.Add("DN Fat");
            type.Add("DN Short");
        }
        public override void AddingTypePizza()
        {
            base.AddingTypePizza();
            Console.WriteLine("ModernPizza is the best");

        }
    }
}
