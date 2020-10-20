using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 4b
            Funtion funtion = new Funtion();
            // input and Check elements in array.
            funtion.Check();

            // Check if array has element = 5
            Console.WriteLine("Array has element = 5 :"+ funtion.CheckContainNumber5());

            // Check if array has element = 5 Or element = 6
            Console.WriteLine("Array has element = 6 :"+ funtion.CheckContainNumber5Or6());

            // Check if array has both element 5 and 6
            Console.WriteLine("Array has element = 6 and element = 5 :"
                + funtion.CheckContainNumber5And6());
            // Count number 5 in array.
            Console.WriteLine("Quantity of elements = 5 in Array :" + funtion.CountNumber5());

            // Count number 5 or number 6 in array.
            Console.WriteLine("Quantity of elements = 5 Or elements = 6 in Array :" 
                + funtion.CountNumber5Or6());

            //caculate the sum of array.
            Console.WriteLine("Sum of all elements in array :" +funtion.Sum());

            #endregion
            Console.ReadKey();
        }
    }
}
