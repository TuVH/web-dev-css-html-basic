using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var dnPizza = new DNPizzaStore();
            dnPizza.OrderPizza("traditionalPizZa");
            var hnPizza = new HNPizzaStore();
            hnPizza.OrderPizza("modernpizza");
            var hcmPizza = new HCMPizzaStore();
            hcmPizza.OrderPizza("GreekPizza");


        }
    }
    
}
