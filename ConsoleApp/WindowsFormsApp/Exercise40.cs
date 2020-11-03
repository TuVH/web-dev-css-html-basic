using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Exercise40
    {

        private int GreatestCommonDivisor(int numA, int numB)
        {
            int result = (numA > numB ? numA : numB);
            for (int i = 1; i <= (numA * numB); i++)
            {
                if (numA % i == 0 && numA % i == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        private int LeastCommonMultiple(int numA, int numB)
        {
            int result = (numA > numB ? numA : numB);
            for (int i = result; i <= (numA * numB); i++)
            {
                if (i % numA == 0 && i % numB == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        public string ShowResult(int numA, int numB)
        {
            string result = "GreatestCommonDivisor :" + numA + ", " + numB + " is:"+
                GreatestCommonDivisor(numA, numB);
            result+="\r\nLeastCommonMultiple     :" + numA + ", " + numB + " is:"+
                LeastCommonMultiple(numA, numB);
            return result;
        }
    }
}
