using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number = Check();
            Funtion f = new Funtion(number);
            Console.WriteLine("Số {0} là số lẻ : {1}", number, f.IsOdd());
            Console.WriteLine("Số {0} là số Chẳn : {1}", number, f.IsEven());
            Console.WriteLine("Số {0} là số nguyên tố : {1}", number, f.IsPrime());
            Console.WriteLine("Số mũ 2 của {0} là {1}", number, f.Square());
            Console.WriteLine("Số mũ 3 của {0} là {1}", number, f.Cube());
            Console.WriteLine("Tri tuyệt đối của {0} là {1}",number,f.Abs());
            Console.WriteLine("Số x ^ y là :{0}",f.Pow(5,2));
            Console.WriteLine(f.Rand1());


            Console.ReadKey();
        }
        static int Check()
        {
            int number = 0;
            Console.WriteLine("Mời bạn nhập số :");

            int.TryParse(Console.ReadLine(), out number);
            while (number == 0)
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại số :");
                int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
    }
}
