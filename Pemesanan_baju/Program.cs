using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    Console.WriteLine("Masukkan Password");
                    string pass = Console.ReadLine();
                    Console.WriteLine("Masukkan database tujuan :");
                    string db = Console.ReadLine();
                    Console.WriteLine("\nKetik C untuk terhubung ke Database: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'C':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "Data source = LAPTOP-P9JKEJMQ\\FARHANSQL;" +
                                    "initial catalog = {0}; " +
                                    "User ID = {1}; password = {2}";
                                conn = new SqlConnection(string.Format(strKoneksi, db, user, pass));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Menambah Data");
                                        Console.WriteLine("2. Mengupdate Data");
                                        Console.WriteLine("3. Menghapus Data");
                                        Console.WriteLine("\nMasukkan pilihan (1-3): ");
                                    }
                                }
                            }
                    }
                }
            }
        }
    }
}
