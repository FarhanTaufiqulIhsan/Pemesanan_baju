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
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Produk");
                                                    Console.WriteLine("Masukkan ID_Produk : ");
                                                    string ID_Produk = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama_Produk: ");
                                                    string Nama_Produk = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Harga_Produk: ");
                                                    string Harga_Produk = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insert(ID_Produk, Nama_Produk, Harga_Produk, conn);
                                                        conn.Close();
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki akses untuk menambah data");
                                                    }
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Mengupdate Data Produk");
                                                    Console.WriteLine("");
                                                }
                                                break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak Dapat Mengakses Database Menggunakan User Tersebut\n");
                    Console.ResetColor();
                }
            }
        }
        public void insert(string ID_Produk, string Nama_Produk, string Harga_Produk,
            SqlConnection con)
        {
            string str = "";
            str = "insert into dbo.Produk (ID_Produk,Nama_Produk,Harga_Produk)"
                + " values(@ID_Produk,@Nama_Produk,@Harga_Produk)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ID_Produk", ID_Produk));
            cmd.Parameters.Add(new SqlParameter("Nama_Produk", Nama_Produk));
            cmd.Parameters.Add(new SqlParameter("Harga_Produk", Harga_Produk));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Ditambahkan");
        }
    }
}
