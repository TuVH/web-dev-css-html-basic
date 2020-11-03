using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Note  
    {
        public object data;        
        public Note Next;
        public Note(object data)
        {
            this.data = data;
        }
    }
}
