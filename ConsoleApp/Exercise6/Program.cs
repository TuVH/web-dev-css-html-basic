using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account tu = new Account();
            tu.Money =0;
            Console.WriteLine("My money:" + tu.Balance());
            tu.Deposit(5000000);
            Console.WriteLine("My money:" + tu.Balance());
            Console.WriteLine(tu.Withdraw(4000000));
            Console.WriteLine("My money:" + tu.Balance());

           
            

            Console.ReadKey();
        }
    }
}
