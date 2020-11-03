using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    class Caculate
    {

        public static string Solve(double a, double b, double c)
        {
            string result;
            double delta = (b / 2) * (b / 2) - a * c;
            switch (delta < 0)
            {
                case true:
                    result = "Chương trình vô nghiệm";
                    return result;
                    break;
                case false:
                    switch (delta == 0)
                    {
                        case true:
                            double x = (-b / 2) / a;
                            result = "Phương trình có nghiệm kép x1 = x2 = {0}" + x;
                            return result;
                            break;
                        default:
                            double x1 = 0;
                            double x2 = 0;

                            x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                            x2 = ((-b / 2) + Math.Sqrt(delta)) / a;


                            result = "Phương trình có 2 nghiệm phân biệt: \n"
                                + "x1 = " + x1 + ", x2 = " + x2;
                            return result;
                            break;
                    }
                default:
                    return "";

            }
        }
    }
}