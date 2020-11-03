using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoThread
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                var temp = i;
                Thread t = new Thread(() =>
                    RunThread("Thread" + temp +": ")
                );
                t.Start();
            }
                
            
            
            
        }
        static void RunThread(string index)
        {
            for (int i = 0; i < 5; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine(index + i);
            }
        }

    }
}
