using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class Exercise38
    {
        public string Tranfer(int money)
        {
            string result = "";
            if (money>500)
            {
                int to500 = (int)money / 500;
                result += "số tờ 500 :" + to500;
                money -= (500 * to500);
            }
            if (money > 200)
            {
                int to200 = (int)money / 200;
                result += "\r\nsố tờ 200 :" + to200;
                money -= (200 * to200);
            }
            if (money > 100)
            {
                int to100 = (int)money / 100;
                result += "\r\nsố tờ 100 :" + to100;
                money -= (100 * to100);
            }
            if (money > 50)
            {
                int to50 = (int)money / 50;
                result += "\r\nsố tờ 50 :" + to50;
                money -= (50 * to50);
            }
            if (money > 20)
            {
                int to20 = (int)money / 20;
                result += "\r\nsố tờ 20 :" + to20;
                money -= (20 * to20);
            }
            if (money > 10)
            {
                int to10 = (int)money / 10;
                result += "\r\nsố tờ 10 :" + to10;
                money -= (10 * to10);
            }
            if (money > 5)
            {
                int to5 = (int)money / 5;
                result += "\r\nsố tờ 5 :" + to5;
                money -= (5 * to5);
            }
            if (money > 2)
            {
                int to2 = (int)money / 2;
                result += "\r\nsố tờ 2 :" + to2;
                money -= (2 * to2);
            }
            if (money >= 1)
            {
                int to1 = (int)money / 1;
                result += "\r\nsố tờ 1 :" + to1;
                money -= (1 * to1);
            }

            return result;
        }
    }
}
