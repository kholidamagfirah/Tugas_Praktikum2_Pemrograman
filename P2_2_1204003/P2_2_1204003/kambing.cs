using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204003
{
    class kambing
    {
        public string nama;
        public int jumlahkaki;
        public string jeniskelamin;

        public void Makan()
        {
            Console.WriteLine("{0} sedang makan. ", nama);
        }

        public void Jalan()
        {
            Console.WriteLine("{0} sedang jalan.", nama);
        }
    }
}
