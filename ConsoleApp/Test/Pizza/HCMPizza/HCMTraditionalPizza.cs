﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HCMTraditionalPizza : Pizza
    {
        public HCMTraditionalPizza()
        {
            name = "HCM TraditionalPizza";
            toppings = "Black olives";
            type.Add("Thin");
            type.Add("Short");
        }

        public override void AddingTypePizza()
        {
            base.AddingTypePizza();
            Console.WriteLine("Traditional pizza is the best");
        }
    }
}
