using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_Hitung_Luas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HitungLuas(double panjang, double lebar)
            {
                double luas = panjang * lebar;
                return luas;
            }


            {
                Console.Write(" Masukan panjang : ");
                double p = Convert.ToDouble(Console.ReadLine());

                Console.Write(" Masukan lebar : ");
                double l = Convert.ToDouble(Console.ReadLine());

                double hasil = HitungLuas(p, l);
                Console.WriteLine(" Hasil luas persegi panjang adalah : " + hasil);
                Console.ReadLine();
            }
        }
    }
}
