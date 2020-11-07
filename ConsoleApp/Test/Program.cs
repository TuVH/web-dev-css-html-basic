using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList link = new LinkList();
            link.AddNote(5);
            link.AddNote(6);
            link.AddFirst(7);
            link.Addmid(8, 1);
            link.Delete(1);
            link.ShowNote();

        }
    }
}
