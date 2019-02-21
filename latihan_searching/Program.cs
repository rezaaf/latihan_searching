using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace latihan_searching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memasukkan Jumlah elemen array
            int[] a = new int[10000000];
            Console.WriteLine("Masukkan Batas Angka ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);

            //Memasukkan elemen pada array
            Console.WriteLine("=======================");
            Console.WriteLine("List Angka ");
            Console.WriteLine("=======================");

            //Proses Pengkonvertan Elemen Array agar bisa dibaca program
            for (int i = 0; i < x; i++)
            {
                a[i]=i+1;
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("=========================");
            Console.WriteLine("Masukan Angka yang dicari");
            Console.WriteLine("=========================");

            //Proses Pendeklarasian Nilai terkecil dan terbesar
            Stopwatch timerr = new Stopwatch();
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            int low = 0;
            int high = x - 1;

            //Proses Pengulangan Untuk Proses Pencarian
            timerr.Start();
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (x2 < a[mid])
                    high = mid - 1;
                else if (x2 > a[mid])
                    low = mid + 1;
                else if (x2 == a[mid])
                {
                    Console.WriteLine("==================");
                    Console.WriteLine("Pencarian Berhasil");
                    Console.WriteLine("==================");
                    Console.WriteLine("Angka {0} ditemukan \n", x2, mid + 1);
                    timerr.Stop();
                    Console.WriteLine("waktu yang di butuhkan : " + timerr.Elapsed);
                    Console.ReadLine();
                    return;
                
                }

            }
            Console.WriteLine("Pencarian Gagal, angka tidak ditemukan");
            timerr.Stop();
            Console.WriteLine("waktu yang di butuhkan : " + timerr.Elapsed);
            Console.ReadLine();

        }


    }
}



