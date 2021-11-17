using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204003
{
    class Program
    {
        static void Main(string[] args)
        {
            kambing kambingsaya;
            kambingsaya = new kambing();
            kambingsaya.nama = "doggie";
            kambingsaya.jeniskelamin = "jantan";
            kambingsaya.jumlahkaki = 8;

            Console.WriteLine("kambing saya bernama {0}. ", kambingsaya.nama);
            Console.WriteLine("jenis kelamin kambing saya {0}. ", kambingsaya.jeniskelamin);
            Console.WriteLine("jumlah kakinya {0}. ", kambingsaya.jumlahkaki);

            kambingsaya.Jalan();
            kambingsaya.Makan();
            Console.ReadLine();
                
        }
    }
}
