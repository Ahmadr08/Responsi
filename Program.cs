using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\n\tNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }
        
        static void TampilMenu()
        {
            int pilih;
            
            Console.WriteLine("\t=============================");
            Console.WriteLine("\t| Nama  : Ahmad Roziqun     |");
            Console.WriteLine("\t| Kelas : 19 Informatika 05 |");
            Console.WriteLine("\t| NIM   : 19.11.2913        |");
            Console.WriteLine("\t=============================");
            Console.WriteLine("\n\t=============================");
            Console.WriteLine("\t|        Pilihan Menu       |");
            Console.WriteLine("\t=============================");
            Console.WriteLine("\t|     1. Tambah Data        |");
            Console.WriteLine("\t|     2. Hapus Data         |");
            Console.WriteLine("\t|     3. Tampilkan Data     |");
            Console.WriteLine("\t|     4. Keluar             |");
            Console.WriteLine("\t=============================");

            Console.ReadKey();
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("\n\t===========================");
            Console.WriteLine("\t|     Menu Tambah Data    |");
            Console.WriteLine("\t===========================");

            Console.Write("\tNota : ");
            penjualan.Nota = Console.ReadLine();
            Console.Write("\tTanggal : ");
            penjualan.Tgl = Console.ReadLine();
            Console.Write("\tCostumer : ");
            penjualan.Pelanggan = Console.ReadLine();
            Console.Write("\tJenis [T/K]");
            penjualan.Jenis = Console.ReadLine();
            Console.Write("\tTotal Nota :");
            penjualan.Total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjualan);
            
            Console.WriteLine("\n\tTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            int no = 1;
            int hapus = 0;

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("\n\t==========================");
                Console.WriteLine("\t|    Hapus Data Penjualan    |");
                Console.WriteLine("\t==========================");
                Console.WriteLine("\t{0}. Nota : {1}", no , penjualan.Nota);

                no++;
                hapus += 1;
            }
            
            Console.Write("\n\tPilih Data Yang Ingin Dihapus [1-");
            Console.Write(hapus);
            Console.Write("] : ");
            int index = int.Parse(Console.ReadLine());
            index = index - 1;

            Console.WriteLine("\n\tTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            int no = 1;

            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\n\t========================");
            Console.WriteLine("\t|     Data Penjualan    |");
            Console.WriteLine("\t========================");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("\n\t{0}. Nota: {1}, \tTanggal: {2}, \tNama: {3}, \t{4}, \tTotal: {5}", no, penjualan.Nota, penjualan.Tgl, penjualan.Pelanggan, penjualan.Jenis, penjualan.Total);

                no++;

            }
            Console.WriteLine("\n\tTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
