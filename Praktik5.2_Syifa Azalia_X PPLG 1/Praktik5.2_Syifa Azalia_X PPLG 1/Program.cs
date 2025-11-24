using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._2_Syifa_Azalia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            Console.WriteLine("Menghitung Jumlah Angka dari 1 sampai 5");

            for (int i = 1; i <= 5; i++)
            {
                total += i;

                Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);
            }

            Console.WriteLine("\nHasil akhir penjumlahan adalah = " + total);

        }
    }
}
