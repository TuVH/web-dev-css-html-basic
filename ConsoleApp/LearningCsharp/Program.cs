using LearningCsharp;
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
            int number1 = Check1();
            float fNumber = Check2();

            Funtion f = new Funtion(number, number1);
            Funtion f1 = new Funtion(fNumber);
            //kiểm tra số lẻ
            Console.WriteLine("Số {0} là số lẻ : {1}", number, f.IsOdd());

            //kiểm tra số chẳn            
            Console.WriteLine("Số {0} là số Chẳn : {1}", number, f.IsEven());

            //kiểm tra số nguyên tố
            Console.WriteLine("Số {0} là số nguyên tố : {1}", number, f.IsPrime());

            //số mũ 2 của số thứ nhất đã nhập vào
            Console.WriteLine("Số mũ 2 của {0} là {1}", number, f.Square());

            //số mũ 3 của số thứ hai đã nhập vào
            Console.WriteLine("Số mũ 3 của {0} là {1}", number, f.Cube());

            //tìm số khi số thứ nhất mũ số thứ 2 đã nhập vào
            Console.WriteLine("Số {0} ^ {1} là :{2}", number, number1, f.Pow());

            //tìm trị tuyệt đối của số thứ 1
            Console.WriteLine("Tri tuyệt đối của {0} là {1}", number, f.Abs());

            //số thực đã nhập làm tròn lên
            Console.WriteLine("Số {0} làm tròn lên là:{1}", fNumber, f1.Ceil());

            //số đã nhập đã nhập làm tròn xuống
            Console.WriteLine("Số {0} làm tròn xuống là:{1}", fNumber, f1.Floor());

            //số nguyên Random giữa 2 số (0,2^31-1)
            Console.WriteLine("số random ngẫu nhiên từ 0->2^31-1 là:{0}", f.Rand1());

            //số thực Random giữa 2 số (0,1)
            Console.WriteLine("số random ngẫu nhiên từ 0->1 là:{0}", f.Rand2());

            //tìm giai thừa số thứ nhất đã nhập
            Console.WriteLine("Giai thừa của số nguyên thứ 1 là {0}", f.Factorial());


            Console.ReadKey();
        }

        private static float Check2()
        {
            float number = 0;
            Console.WriteLine("Mời bạn nhập 1 số thực:");
            float.TryParse(Console.ReadLine(), out number);
            while (number == 0)
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại số :");
                float.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        private static int Check()
        {
            int number = 0;
            Console.WriteLine("Mời bạn nhập số nguyen thứ 1:");

            int.TryParse(Console.ReadLine(), out number);
            while (number == 0)
            {
                Console.WriteLine("Nhập sai, vui lòng nhập lại số :");
                int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        private static int Check1()
        {
            int number = 0;
            Console.WriteLine("Mời bạn nhập số nguyen thứ 2:");

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
