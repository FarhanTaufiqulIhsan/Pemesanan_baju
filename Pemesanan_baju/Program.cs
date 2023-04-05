using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemesanan_baju
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("Keoneksi Ke Database\n");
                    Console.WriteLine("Masukkan User ID : ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Masukkan database tujuan :");
                    string db = Console.ReadLine();
                    Console.WriteLine("\nKetik C untuk terhubung ke Database: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                }
            }
        }
    }
}
