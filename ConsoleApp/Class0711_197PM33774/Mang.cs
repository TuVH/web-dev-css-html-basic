using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0711_197PM33774
{
    class Mang
    {
        List<int> array = new List<int>();
        public Mang(List<int> array)
        {
            this.array = array;
        }
        public string Ketqua()
        {
            string ketqua = "Mảng : ";
            foreach (var item in array)
            {
                ketqua += item +" ";
            }
            return ketqua;
        }
        public int Tong()
        {
            int ketqua = 0;
            foreach (var item in array)
            {
                ketqua += item;
            }
            return ketqua;
        }
        public double Trungbinh()
        {
            double ketqua = 0;
            foreach (var item in array)
            {
                ketqua = Tong()*1.0 / array.Count();
            }
            return ketqua;
        }
    }
}
