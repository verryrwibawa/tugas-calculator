/*
 * Program : Calculator 
 * Author  : Verry R. Wibawa 
 */

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input menu calc
            int menu = inputMenu();

            // input angka1, angka2
            int a = inputAngka1();
            int b = inputAngka2();

            // menampilkan garis
            garis();
            
            // menampilkan hasil perhitungan
            calc(menu, a, b);

            // Pause
            Console.ReadKey();
        }

        static int inputMenu()
        {
            garis();
            Console.WriteLine("| Menu Calculator");
            garis();
            Console.WriteLine("| 1. Penambahan \n" +
                              "| 2. Pengurangan\n" +
                              "| 3. Perkalian  \n" +
                              "| 4. Pembagian    " );
            garis();
            Console.Write("| Pilih menu : ");

            return Convert.ToInt32(Console.ReadLine());
        }

        static int inputAngka1()
        {
            garis();
            Console.Write("| Masukkan angka 1 : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int inputAngka2()
        {
            Console.Write("| Masukkan angka 2 : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void calc(int menu, int a, int b)
        {
            Console.Write("\n");
            garis();
            Console.Write("| Hasil ");
            switch (menu)
            {
                case 1:
                    Console.Write("Penjumlahan : {0}", tambah(a, b));
                    break;
                case 2:
                    Console.Write("Pengurangan : {0}", kurang(a, b));
                    break;
                case 3:
                    Console.Write("Perkalian : {0}", kali(a, b));
                    break;
                case 4:
                    Console.Write("Pembagian : {0}", bagi(a, b));
                    break;
            }
            Console.Write("\n");
            garis();
        }

        // Garis
        static void garis()
        {
            Console.WriteLine("|----------------------------");
        }

        // Aritmatika
        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }
        static int kali(int a, int b)
        {
            return a * b;
        }
        static int bagi(int a, int b)
        {
            return a / b;
        }
    }
}
