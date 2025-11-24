using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._8_Syifa_Azalia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangPilihan;

            do
            {
                Console.WriteLine("--------------------");
                Console.Write("Masukkan nama Anda: ");
                string nama = Console.ReadLine() ?? "";
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");

                Console.WriteLine
                ("\nApakah Anda ingin mengulang program? (y/n)");
                ulangPilihan = Console.ReadLine() ?? "";
            } while (ulangPilihan.ToLower() == "y");
            {
                Console.WriteLine("Terima kasih telah menggunakan program ini.");
            }

        }
    }
}
