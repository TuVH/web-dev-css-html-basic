using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funtion> f = new List<Funtion>();
            for (int i = 0; i < 3; i++)
            {
                Funtion funtion = new Funtion();
                funtion.Input();
                f.Add(funtion);
            }
            foreach (var item in f)
            {
                item.Output();
            }
        }
        

    }
    
}
