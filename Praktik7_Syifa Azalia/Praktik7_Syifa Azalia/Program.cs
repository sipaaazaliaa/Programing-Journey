using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7_Syifa_Azalia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Praktik 7.1
            void Sapa()
            {
                Console.WriteLine(" Hallo, selamat datang di pembelajaran C#! ");
                Console.WriteLine(" Mari belajar tentang fungsi!");
            }

            {
                Sapa(); // Memanggil fungsi
                Console.ReadLine();
            }
            // Praktik 7.2
            void SapaNama(string Nama)
            {
                Console.WriteLine(" Hallo, " + Nama + "!");
                Console.WriteLine(" Semangat belajar C# hari ini!");
            }
            {
                Console.Write(" Masukan nama Anda: ");
                string namaSiswa = Console.ReadLine();
                SapaNama(namaSiswa); // Memanggil fungsi dengan argumen
                Console.ReadLine();
            }
            // Praktik 7.3
            int Tambah(int a, int b)
            {
                return a + b;
            }


            {
                Console.Write(" Masukan angka pertama : ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Masukab angka kedua : ");
                int y = Convert.ToInt32(Console.ReadLine());

                int hasil = Tambah(x, y);
                Console.WriteLine(" Hasil penjumlahan : " + hasil);
                Console.ReadLine();
            }
            // Tugas 1 praktik 7

            {
                // Input 3 bilangan
                Console.Write("Masukkan bilangan pertama: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan bilangan kedua  : ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan bilangan ketiga : ");
                double c = Convert.ToDouble(Console.ReadLine());

                // Operasi Matematika
                double penjumlahan = a + b + c;
                double pengurangan = a - b - c;
                double perkalian = a * b * c;
                double pembagian = a / b / c; // dibagi berurutan: (a ÷ b) ÷ c

                // Hasil
                Console.WriteLine("\n=== HASIL PERHITUNGAN ===");
                Console.WriteLine($"Penjumlahan : {a} + {b} + {c} = {penjumlahan}");
                Console.WriteLine($"Pengurangan : {a} - {b} - {c} = {pengurangan}");
                Console.WriteLine($"Perkalian   : {a} x {b} x {c} = {perkalian}");
                Console.WriteLine($"Pembagian   : ({a} ÷ {b}) ÷ {c} = {pembagian}");

                Console.WriteLine("\nTekan ENTER untuk keluar...");
                Console.ReadLine();

                // Tugas 2 Praktik 7

                {
                    // Input Data Siswa
                    Console.Write("Nama Siswa                   :");
                    string nama = Console.ReadLine();

                    Console.Write("Kelas                        :");
                    string kelas = Console.ReadLine();

                    Console.Write("Nilai Matematika             :");
                    double matematika = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai Bahasa Indonesia       :");
                    double Indonesia = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai Bahasa Inggris         :");
                    double Inggris = Convert.ToDouble(Console.ReadLine());

                    // Hitung rata-rata
                    double rataRata = (matematika + Indonesia + Inggris) / 3;

                    // Tampiklan Hasil
                    Console.WriteLine("\n===== Data Nilai Siswa =====");
                    Console.WriteLine("Nama Siswa                :" + nama);
                    Console.WriteLine("Kelas                     :" + kelas);
                    Console.WriteLine("Nilai Matematika          :" + matematika);
                    Console.WriteLine("Nilai Bahassa Indonesia   :" + Indonesia);
                    Console.WriteLine("Nilai Bahasa Inggris      :" + Inggris);
                    Console.WriteLine("Nilai Rata-rata           :" + rataRata);
                    Console.ReadLine();
                }
                // Tugas 3 Praktik 7
                Console.Write("Masukkan suhu dalam Celcius: ");
                double celcius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celcius * 9 / 5) + 32;
                double reamur = celcius * 4 / 5;
                Console.WriteLine("\n---hasil konverensi---");
                Console.WriteLine($"Suhu dalam Fahrenheit: {fahrenheit} °F");
                Console.WriteLine($"Suhu dalam Reamur: {reamur} °R");
                Console.ReadKey();
            }
        }
    }
}
