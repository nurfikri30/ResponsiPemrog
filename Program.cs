using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;
                    case 2:
                        HapusProduk();
                        break;
                    case 3:
                        TampilProduk();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();


        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Produk");
            Console.WriteLine();
            Console.Write("Kode Produk :");
            produk.Kode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nama Produk :");
            produk.Nama = Console.ReadLine();
            Console.Write("Harga beli :");
            produk.Beli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual :");
            produk.Jual = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(produk);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Produk produk = new Produk();
            Console.Clear();

            Console.Write("Kode Produk :");
            int kode = Convert.ToInt32(Console.ReadLine());
            Produk del = daftarProduk.SingleOrDefault(f => f.Kode == kode);
            if (daftarProduk.Contains(del) == true)
            {
                daftarProduk.Remove(del);
                Console.WriteLine("Data Produk Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("Data Produk Tidak Ditemukan");
            }    

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int no = 1;
            Console.WriteLine("Data Produk");

            foreach (Produk pdk in daftarProduk)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, pdk.Kode, pdk.Nama, pdk.Beli, pdk.Jual);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
