using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Funtion
    {
        private int[] arr;
        public void Check()
        {
            int iNumber = 0;
            while (iNumber <= 0)
            {
                Console.Write("Input length of array :");
                int.TryParse(Console.ReadLine(), out iNumber);
                arr = new int[iNumber];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int elements;
                Console.Write("input array[{0}]:", i);

                bool success = int.TryParse(Console.ReadLine(), out elements);
                while (!success)
                {
                    Console.Write("Wrong input! , try again!,input array[{0}]:", i);
                    success = int.TryParse(Console.ReadLine(), out elements);
                }
                arr[i] = elements;
            }
        }
        public bool CheckContainNumber5()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckContainNumber6()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckContainNumber5Or6()
        {
            if (CheckContainNumber5() || CheckContainNumber6())
            {
                return true;
            }
            return false;
        }
        public bool CheckContainNumber5And6()
        {
            if (CheckContainNumber5() && CheckContainNumber6())
            {
                return true;
            }
            return false;
        }
        public int CountNumber5()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] ==5 )
                {
                    count++;
                }
            }
            return count;
        }
        public int CountNumber5Or6()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] ==6)
                {
                    count++;
                }
            }
            return count;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

    }
}
