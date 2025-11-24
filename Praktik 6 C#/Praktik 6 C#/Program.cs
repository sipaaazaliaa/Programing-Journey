using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Praktik 6.1
            string[] siswa = new string[5];
            siswa[0] = "Andi";
            siswa[1] = "Budi";
            siswa[2] = "Citra";
            siswa[3] = "Dewi";
            siswa[4] = "Eka";

            Console.WriteLine( "Daftar Nama Siswa: ");
            Console.WriteLine("Siswa ke-1: " + siswa[0]);
            Console.WriteLine("Siswa ke-2: " + siswa[1]);
            Console.WriteLine("Siswa ke-3: " + siswa[2]);
            Console.WriteLine("Siswa ke-4: " + siswa[3]);
            Console.WriteLine("Siswa ke-5: " + siswa[4]);

            //Praktik 6.2
            int[] angka = new int[5];
            Console.WriteLine("Masukkan nilai ke-1: ");
            angka[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-2: ");
            angka[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-3: ");
            angka[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-4: ");
            angka[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai ke-5: ");
            angka[4] = Convert.ToInt32(Console.ReadLine());

            //Praktik 6.3
            String[] nama = new string[3];
            int[] nilai = new int[3];

            Console.WriteLine("Masukkkan nama siswa ke-1");
            nama[0] = Console.ReadLine();
            Console.WriteLine("Masukkan nilai siswa ke-1");
            nilai[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkkan nama siswa ke-2");
            nama[1] = Console.ReadLine();
            Console.WriteLine("Masukkan nilai siswa ke-2");
            nilai[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkkan nama siswa ke-3");
            nama[2] = Console.ReadLine();
            Console.WriteLine("Masukkan nilai siswa ke-3");
            nilai[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== Data Siswa ===");
            Console.WriteLine("Nama: " + nama[0] + " | Nilai: " + nilai[0]);
            Console.WriteLine("Nama: " + nama[1] + " | Nilai: " + nilai[1]);
            Console.WriteLine("Nama: " + nama[2] + " | Nilai: " + nilai[2]);

            //Tugas Praktik 6

            string[] nma = new string[3];
            char[] jk = new char[3];
            string[] kelas = new string[3];

            Console.Write("Masukkan nama siswa ke-1: "); 
            nma[0] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): "); 
            jk[0] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kelas[0] = Console.ReadLine();

            Console.Write("Masukkan nama siswa ke-2: "); 
            nma[1] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): "); 
            jk[1] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: "); 
            kelas[1] = Console.ReadLine();

            Console.Write("Masukkan nama siswa ke-3: ");
            nma[2] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P): "); 
            jk[2] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas: ");
            kelas[2] = Console.ReadLine();

            Console.WriteLine("\n=== Data Siswa ===");
            Console.WriteLine($"Nama: {nma[0]} | Jenis Kelamin: {jk[0]} | Kelas: {kelas[0]}");
            Console.WriteLine($"Nama: {nma[1]} | Jenis Kelamin: {jk[1]} | Kelas: {kelas[1]}");
            Console.WriteLine($"Nama: {nma[2]} | Jenis Kelamin: {jk[2]} | Kelas: {kelas[2]}");
        }
    }
}
