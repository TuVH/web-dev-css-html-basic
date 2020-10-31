using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Funtion
    {
        private string id;
        private string name;
        private string age;

        public Funtion()
        {
        }

        public void Input()
        {
            Console.WriteLine("ID:");
            id = Console.ReadLine();
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Age:");
            age = Console.ReadLine();

        }
        public void Output()
        {
            Console.WriteLine("id:" + id + " name:" + name + " Age:" + age);
        }
        public void Find(List<Funtion> f,int n, string value)
        {
            int left = 0;
            int right = n - 1;
            int mid;
            for (int i = 0; i < n; i++)
            {
                mid = (left + right) / 2;
                if (f[mid].id == value)
                {

                }
            }
        }


    }
}
