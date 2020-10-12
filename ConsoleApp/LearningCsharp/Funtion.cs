using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Funtion
    {
        private int iNumber;
        private int iNumber1;
        private float fNumber;
        Random r = new Random();
        public Funtion(float fNumber)
        {
            this.fNumber = fNumber;
        }

        public Funtion(int iNumber, int iNumber1) 
        {
            this.iNumber = iNumber;
            this.iNumber1 = iNumber1;
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
        public int Pow()
        {
            int number = 1;
            for (int i = 0; i < iNumber1; i++)
            {
                number *= iNumber;
            }
            return number;
        }
        public int Rand1()
        {
            return r.Next(0, 2147483647);
        }
        public float Rand2()
        {
            return (float)r.NextDouble();
        }
        public int Ceil()
        {
            return (int) (fNumber + 1);
        }
        public int Floor()
        {
            return (int) (fNumber );
        }
        public long Factorial() 
        {
            int temp = 1;
            for (int i = 2; i <= iNumber; i++)
            {
                temp *= i;
            }
            return temp;
        }



    }
}