using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Funtion
    {
        private int iNumber;
        public Funtion(int number)
        {
            this.iNumber = number;
        }

        public bool IsOdd()
        {
            if (iNumber % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public bool IsEven()
        {
            if (iNumber % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public bool IsPrime()
        {
            if (iNumber == 1)
            {
                return false;
            }
            for (int i = 2; i < iNumber / 2; i++)
            {
                if (iNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int Square()
        {
            return iNumber * iNumber;
        }
        public int Cube()
        {
            return iNumber * iNumber * iNumber;
        }
        public int Abs()
        {
            if (iNumber < 0)
            {
                return -iNumber;
            }
            return iNumber;
        }
        public int Pow(int x, int y)
        {
            int number = 1;
            for (int i = 0; i < y; i++)
            {
                number *= x;
            }
            return number;
        }
        public int Rand1()
        {
            Random r = new Random();
            return r.Next(0, (int) Math.Pow(2,31) - 1);
        }

    }
}

