using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._6_Syifa_Azalia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            do
            {
                Console.Write("Masukkan angka genap: ");
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid. Masukkan angka genap.");
                    angka = 1;
                    continue;
                }
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi.");
                }
            } while (angka % 2 != 0);
            Console.WriteLine($"Selamat! Anda memasukkan angka genap: {angka}.");
        }
    }
}
